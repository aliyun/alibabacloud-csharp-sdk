// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateOfficeConversionTaskRequest : TeaModel {
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// 转换终止页，包含终止页，默认转换到最后一页，表格转图片时需要指定 SheetIndex 才有效
        /// </summary>
        [NameInMap("EndPage")]
        [Validation(Required=false)]
        public long? EndPage { get; set; }

        /// <summary>
        /// 表格转图片参数，是否只返回表格的第一张图片，默认为否
        /// </summary>
        [NameInMap("FirstPage")]
        [Validation(Required=false)]
        public bool? FirstPage { get; set; }

        /// <summary>
        /// 表格转图片参数，是否将所有行输出到一张图片，默认为否
        /// </summary>
        [NameInMap("FitToHeight")]
        [Validation(Required=false)]
        public bool? FitToHeight { get; set; }

        /// <summary>
        /// 表格转图片参数，是否将所有列输出到一张图片，默认为否
        /// </summary>
        [NameInMap("FitToWidth")]
        [Validation(Required=false)]
        public bool? FitToWidth { get; set; }

        /// <summary>
        /// 转文本时是否保留文档中的换行符，默认不保留
        /// </summary>
        [NameInMap("HoldLineFeed")]
        [Validation(Required=false)]
        public bool? HoldLineFeed { get; set; }

        /// <summary>
        /// 输出图片 DPI，允许范围 96-600，默认 96
        /// </summary>
        [NameInMap("ImageDPI")]
        [Validation(Required=false)]
        public long? ImageDPI { get; set; }

        /// <summary>
        /// 转图片时是否转换成一张长图，最多支持将 20 页合成一张长图，超过可能报错，默认为不转成长图
        /// </summary>
        [NameInMap("LongPicture")]
        [Validation(Required=false)]
        public bool? LongPicture { get; set; }

        /// <summary>
        /// 转文本时是否转换成长文本，默认每页是个独立的文本
        /// </summary>
        [NameInMap("LongText")]
        [Validation(Required=false)]
        public bool? LongText { get; set; }

        /// <summary>
        /// 表格转图片的最大列数，在 LongPicture 为 true 时生效，默认转所有列
        /// </summary>
        [NameInMap("MaxSheetColumn")]
        [Validation(Required=false)]
        public long? MaxSheetColumn { get; set; }

        /// <summary>
        /// 表格转图片的最大行数，在 LongPicture 为 true 时生效，默认转所有行
        /// </summary>
        [NameInMap("MaxSheetRow")]
        [Validation(Required=false)]
        public long? MaxSheetRow { get; set; }

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
        /// 指定转换页码，优先级高于 StartPage/EndPage，格式：多个页码用 “," 拼接，连续页码用 "-" 连接，样例参考: 1,2-4,7
        /// </summary>
        [NameInMap("Pages")]
        [Validation(Required=false)]
        public string Pages { get; set; }

        /// <summary>
        /// 表格转图片纸张是否水平放置，默认为否
        /// </summary>
        [NameInMap("PaperHorizontal")]
        [Validation(Required=false)]
        public bool? PaperHorizontal { get; set; }

        /// <summary>
        /// 表格转图片纸张大小，支持 A4/A2/A0，默认A4，配合 FitToHeight 或 FitToWidth 一起使用才有效
        /// </summary>
        [NameInMap("PaperSize")]
        [Validation(Required=false)]
        public string PaperSize { get; set; }

        /// <summary>
        /// 文档密码
        /// </summary>
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
        /// 质量参数，范围是0-100，越大质量越好，默认系统自动选择适合的分辨率
        /// </summary>
        [NameInMap("Quality")]
        [Validation(Required=false)]
        public long? Quality { get; set; }

        /// <summary>
        /// 缩放参数，允许范围 20~200，100代表不缩放，小于100表示缩小，大于100表示放大，默认不缩放
        /// </summary>
        [NameInMap("ScalePercentage")]
        [Validation(Required=false)]
        public long? ScalePercentage { get; set; }

        /// <summary>
        /// 表格转图片参数，指定转换表格中的 sheet 数量，默认转换所有 sheet
        /// </summary>
        [NameInMap("SheetCount")]
        [Validation(Required=false)]
        public long? SheetCount { get; set; }

        /// <summary>
        /// 表格转图片参数，指定转换哪一个 sheet，从 1 开始，默认从起始页开始转
        /// </summary>
        [NameInMap("SheetIndex")]
        [Validation(Required=false)]
        public long? SheetIndex { get; set; }

        /// <summary>
        /// 文字转图片，是否显示批注，目前只支持文字转图片时携带批注，默认不显示批注
        /// </summary>
        [NameInMap("ShowComments")]
        [Validation(Required=false)]
        public bool? ShowComments { get; set; }

        /// <summary>
        /// 输入文件格式，默认使用文件名后缀小写格式
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// 文档转换输入文件地址
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// 转换起始页，从 1 开始，包含起始页，默认从第一页开始转换，表格转图片时需要指定 SheetIndex 才有效
        /// </summary>
        [NameInMap("StartPage")]
        [Validation(Required=false)]
        public long? StartPage { get; set; }

        /// <summary>
        /// 用户自定义标签
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// 输出文件格式
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// 文档转换输出地址模式
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        /// <summary>
        /// 文档转换输出文件地址前缀
        /// </summary>
        [NameInMap("TargetURIPrefix")]
        [Validation(Required=false)]
        public string TargetURIPrefix { get; set; }

        /// <summary>
        /// 表格瘦身
        /// </summary>
        [NameInMap("TrimPolicy")]
        [Validation(Required=false)]
        public TrimPolicy TrimPolicy { get; set; }

        /// <summary>
        /// 用户自定义数据，在消息通知中返回
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
