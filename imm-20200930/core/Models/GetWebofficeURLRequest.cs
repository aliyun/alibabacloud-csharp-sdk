// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetWebofficeURLRequest : TeaModel {
        /// <summary>
        /// 项目名称
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 预览编辑地址
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// 文件名，必须带文件名后缀，默认是 SourceUri 的最后一级
        /// </summary>
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        /// <summary>
        /// 用户自定义数据，在消息通知中返回
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// 预览前几页
        /// </summary>
        [NameInMap("PreviewPages")]
        [Validation(Required=false)]
        public long? PreviewPages { get; set; }

        /// <summary>
        /// 文件密码
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// 是否支持外部上传
        /// </summary>
        [NameInMap("ExternalUploaded")]
        [Validation(Required=false)]
        public bool? ExternalUploaded { get; set; }

        /// <summary>
        /// mns 消息通知地址
        /// </summary>
        [NameInMap("NotifyEndpoint")]
        [Validation(Required=false)]
        public string NotifyEndpoint { get; set; }

        /// <summary>
        /// mns 消息通知 topic
        /// </summary>
        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        /// <summary>
        /// 隐藏工具栏，预览模式下使用
        /// </summary>
        [NameInMap("Hidecmb")]
        [Validation(Required=false)]
        public bool? Hidecmb { get; set; }

        /// <summary>
        /// 权限
        /// </summary>
        [NameInMap("Permission")]
        [Validation(Required=false)]
        public WebofficePermission Permission { get; set; }

        /// <summary>
        /// 用户
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public WebofficeUser User { get; set; }

        /// <summary>
        /// 水印
        /// </summary>
        [NameInMap("Watermark")]
        [Validation(Required=false)]
        public WebofficeWatermark Watermark { get; set; }

        /// <summary>
        /// 链式授权
        /// </summary>
        [NameInMap("AssumeRoleChain")]
        [Validation(Required=false)]
        public AssumeRoleChain AssumeRoleChain { get; set; }

    }

}
