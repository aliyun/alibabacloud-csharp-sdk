// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class AddUserSourceLogConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddUserSourceLogConfigResponseBodyData Data { get; set; }
        public class AddUserSourceLogConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The detailed Simple Log Service (SLS) information for log ingestion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai.siem-project.siem-logstore</para>
            /// </summary>
            [NameInMap("DiplayLine")]
            [Validation(Required=false)]
            public string DiplayLine { get; set; }

            /// <summary>
            /// <para>Indicates whether the ingestion details are returned. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The ingestion details are returned.</description></item>
            /// <item><description>false: The ingestion details are not returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Displayed")]
            [Validation(Required=false)]
            public bool? Displayed { get; set; }

            /// <summary>
            /// <para>Indicates whether the logs are ingested. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The logs are ingested.</description></item>
            /// <item><description>false: The logs are not ingested.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Imported")]
            [Validation(Required=false)]
            public bool? Imported { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID that purchased Threat Analysis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123XXXXXXXXX</para>
            /// </summary>
            [NameInMap("MainUserId")]
            [Validation(Required=false)]
            public long? MainUserId { get; set; }

            /// <summary>
            /// <para>The log code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_siem_aegis_proc</para>
            /// </summary>
            [NameInMap("SourceLogCode")]
            [Validation(Required=false)]
            public string SourceLogCode { get; set; }

            /// <summary>
            /// <para>The product code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas</para>
            /// </summary>
            [NameInMap("SourceProdCode")]
            [Validation(Required=false)]
            public string SourceProdCode { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID for Threat Analysis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123XXXXXXXX</para>
            /// </summary>
            [NameInMap("SubUserId")]
            [Validation(Required=false)]
            public long? SubUserId { get; set; }

            /// <summary>
            /// <para>The name of the Alibaba Cloud account for Threat Analysis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas_account_xxx</para>
            /// </summary>
            [NameInMap("SubUserName")]
            [Validation(Required=false)]
            public string SubUserName { get; set; }

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
