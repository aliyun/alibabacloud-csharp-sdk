// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20210325.Models
{
    public class CreateScheduleRequest : TeaModel {
        /// <summary>
        /// 数据源地址
        /// - 0: project/table
        /// MaxCompute项目名和表名，使用前需要授权
        /// - 1: oss地址 https://bucket.endpoint/path/to/file
        /// OSS地址，必须以https开头，使用前需要授权，如 https://bucket.endpoint/path/to/file
        /// </summary>
        [NameInMap("DataAddress")]
        [Validation(Required=false)]
        public string DataAddress { get; set; }

        /// <summary>
        /// 数据源类型
        /// - 0: MaxCompute
        /// - 1: CSV
        /// 数据源类型为CSV时，可以提供不带header的CSV文件或带header的CSV文件
        /// 不带header的CSV文件每行为一个手机号
        /// 使用带header的CSV文件，如果不指定手机号列名，默认使用第一列为手机号
        /// 其他列可用于替换模板中的形如${variable}的变量，实现个性化发送
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public int? DataSource { get; set; }

        /// <summary>
        /// 钉钉机器人关键词
        /// </summary>
        [NameInMap("DingBotKeyword")]
        [Validation(Required=false)]
        public string DingBotKeyword { get; set; }

        /// <summary>
        /// 钉钉机器人token
        /// </summary>
        [NameInMap("DingBotToken")]
        [Validation(Required=false)]
        public string DingBotToken { get; set; }

        /// <summary>
        /// 发送计划名称
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 分区表达式
        /// </summary>
        [NameInMap("Partition")]
        [Validation(Required=false)]
        public string Partition { get; set; }

        /// <summary>
        /// 手机号列名
        /// </summary>
        [NameInMap("PhoneNumberColumn")]
        [Validation(Required=false)]
        public string PhoneNumberColumn { get; set; }

        /// <summary>
        /// 发布时间 (UTC+8)，建议距现在10分钟后，不能距现在超过一年，否则会发生回绕，格式必须是2020-01-01 12:00:00
        /// </summary>
        [NameInMap("SendTime")]
        [Validation(Required=false)]
        public string SendTime { get; set; }

        /// <summary>
        /// 签名ID
        /// </summary>
        [NameInMap("SignatureID")]
        [Validation(Required=false)]
        public string SignatureID { get; set; }

        /// <summary>
        /// 模板号列名(可选)
        /// </summary>
        [NameInMap("TemplateCodeColumn")]
        [Validation(Required=false)]
        public string TemplateCodeColumn { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        [NameInMap("TemplateID")]
        [Validation(Required=false)]
        public string TemplateID { get; set; }

    }

}
