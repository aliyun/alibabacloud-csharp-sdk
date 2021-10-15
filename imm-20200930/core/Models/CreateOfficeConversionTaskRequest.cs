// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateOfficeConversionTaskRequest : TeaModel {
        /// <summary>
        /// 结束转换页，如果是 excel 需要指定 SheetIndex
        /// </summary>
        [NameInMap("EndPage")]
        [Validation(Required=false)]
        public string EndPage { get; set; }

        /// <summary>
        /// 表格转图片参数，只返回表格的第一张图片，图片包含的行数列数是自动切割的结果。必须在LongPic为true的情况下才有效。默认为false
        /// </summary>
        [NameInMap("FirstPage")]
        [Validation(Required=false)]
        public bool? FirstPage { get; set; }

        /// <summary>
        /// 表格转图片，所有行输出到一张图片
        /// </summary>
        [NameInMap("FitToHeight")]
        [Validation(Required=false)]
        public bool? FitToHeight { get; set; }

        /// <summary>
        /// 表格转图片，所有列输出到一张图片
        /// </summary>
        [NameInMap("FitToWidth")]
        [Validation(Required=false)]
        public bool? FitToWidth { get; set; }

        /// <summary>
        /// 水平放置纸张，默认 false
        /// </summary>
        [NameInMap("IsHorizontal")]
        [Validation(Required=false)]
        public bool? IsHorizontal { get; set; }

        /// <summary>
        /// 转图片，合成一个一张产长图，最多20张图片，默认 false
        /// </summary>
        [NameInMap("LongPic")]
        [Validation(Required=false)]
        public bool? LongPic { get; set; }

        /// <summary>
        /// mns 消息地址
        /// </summary>
        [NameInMap("NotifyEndpoint")]
        [Validation(Required=false)]
        public string NotifyEndpoint { get; set; }

        /// <summary>
        /// mns 消息 topic
        /// </summary>
        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        /// <summary>
        /// 纸张大小 A4, A2, A0，默认 A4
        /// </summary>
        [NameInMap("PaperSize")]
        [Validation(Required=false)]
        public string PaperSize { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 转化质量0~100
        /// </summary>
        [NameInMap("Quality")]
        [Validation(Required=false)]
        public long? Quality { get; set; }

        /// <summary>
        /// 缩放大小 20~200，默认100，小于100缩放，大于100放大
        /// </summary>
        [NameInMap("Scale")]
        [Validation(Required=false)]
        public long? Scale { get; set; }

        /// <summary>
        /// excel 转换 sheet 的数量，默认转换所有
        /// </summary>
        [NameInMap("SheetCount")]
        [Validation(Required=false)]
        public string SheetCount { get; set; }

        /// <summary>
        /// excel 标签页，从 1 开始
        /// </summary>
        [NameInMap("SheetIndex")]
        [Validation(Required=false)]
        public long? SheetIndex { get; set; }

        /// <summary>
        /// 显示批注
        /// </summary>
        [NameInMap("ShowComments")]
        [Validation(Required=false)]
        public bool? ShowComments { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("SourceUri")]
        [Validation(Required=false)]
        public string SourceUri { get; set; }

        /// <summary>
        /// 开始转换页，如果是 excel 需要指定 SheetIndex
        /// </summary>
        [NameInMap("StartPage")]
        [Validation(Required=false)]
        public string StartPage { get; set; }

        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        [NameInMap("TargetUri")]
        [Validation(Required=false)]
        public string TargetUri { get; set; }

        /// <summary>
        /// 用户自定义信息，此信息将在 Task 中回传
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
