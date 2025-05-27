// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListImportedLogsByProdResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListImportedLogsByProdResponseBodyData> Data { get; set; }
        public class ListImportedLogsByProdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the log is automatically added to the threat analysis feature within newly added accounts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: yes.</description></item>
            /// <item><description>0: no.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-23 12:30:00</para>
            /// </summary>
            [NameInMap("AutoImported")]
            [Validation(Required=false)]
            public int? AutoImported { get; set; }

            /// <summary>
            /// <para>The code of the cloud service provider. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>qcloud: Tencent Cloud.</description></item>
            /// <item><description>aliyun: Alibaba Cloud.</description></item>
            /// <item><description>hcloud: Huawei Cloud.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>hcloud</para>
            /// </summary>
            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            /// <summary>
            /// <para>Indicates whether the log is added to the threat analysis feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: yes.</description></item>
            /// <item><description>0: no.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-23 12:30:00</para>
            /// </summary>
            [NameInMap("Imported")]
            [Validation(Required=false)]
            public int? Imported { get; set; }

            /// <summary>
            /// <para>The number of users who have added the log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ImportedUserCount")]
            [Validation(Required=false)]
            public int? ImportedUserCount { get; set; }

            /// <summary>
            /// <para>The code of the log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_siem_waf_xxxxx</para>
            /// </summary>
            [NameInMap("LogCode")]
            [Validation(Required=false)]
            public string LogCode { get; set; }

            /// <summary>
            /// <para>The display code of the log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>${siem.prod. cloud_siem_waf_xxxxx}</para>
            /// </summary>
            [NameInMap("LogMdsCode")]
            [Validation(Required=false)]
            public string LogMdsCode { get; set; }

            /// <summary>
            /// <para>The type of log. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: the log produced by other product</description></item>
            /// <item><description>2: the predefined log</description></item>
            /// <item><description>3: the custom log</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LogType")]
            [Validation(Required=false)]
            public int? LogType { get; set; }

            /// <summary>
            /// <para>The time when the log was last added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-23 12:30:00</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The code of the cloud service to which the log belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qcloud_waf</para>
            /// </summary>
            [NameInMap("ProdCode")]
            [Validation(Required=false)]
            public string ProdCode { get; set; }

            /// <summary>
            /// <para>The total number of users who have the log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalUserCount")]
            [Validation(Required=false)]
            public int? TotalUserCount { get; set; }

            /// <summary>
            /// <para>The number of users who have not added the log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("UnImportedUserCount")]
            [Validation(Required=false)]
            public int? UnImportedUserCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
