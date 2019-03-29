﻿using Rabbit.WeiXin.Utility.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Rabbit.WeiXin.MP.Messages.Response
{
    /// <summary>
    /// 图片响应消息。
    /// </summary>
    public sealed class ResponseMessageImage : ResponseMessageBase, IMediaMessage
    {
        
        /// <summary>
        /// 初始化一个新的图片响应消息。
        /// </summary>
        public ResponseMessageImage()
        {
        }

        /// <summary>
        /// 初始化一个新的图片响应消息。
        /// </summary>
        /// <param name="mediaId">媒体Id。</param>
        public ResponseMessageImage(string mediaId)
        {
            MediaId = mediaId.NotEmptyOrWhiteSpace("mediaId");
        }

        
        
        /// <summary>
        /// 消息类型。
        /// </summary>
        public override ResponseMessageType MessageType
        {
            get { return ResponseMessageType.Image; }
        }

        
        
        /// <summary>
        /// 媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        [Required]
        public string MediaId { get; set; }

            }
}