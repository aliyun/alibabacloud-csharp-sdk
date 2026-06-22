// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckWarningDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The hardening suggestion for the baseline check risk item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You can fix it in the following ways:↵1. To configure authentication for redis service, click the redis.conf Configure complex password in requirepass, and then restart redis.↵2. In redis configuration file redis.conf The configuration is as follows: bind 127.0.0.1, only allow local access, and then restart redis</para>
        /// </summary>
        [NameInMap("Advice")]
        [Validation(Required=false)]
        public string Advice { get; set; }

        /// <summary>
        /// <para>The list of checked asset details.</para>
        /// </summary>
        [NameInMap("CheckDetailAssetInfo")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> CheckDetailAssetInfo { get; set; }

        /// <summary>
        /// <para>The details of the check content.</para>
        /// </summary>
        [NameInMap("CheckDetailColumns")]
        [Validation(Required=false)]
        public List<DescribeCheckWarningDetailResponseBodyCheckDetailColumns> CheckDetailColumns { get; set; }
        public class DescribeCheckWarningDetailResponseBodyCheckDetailColumns : TeaModel {
            /// <summary>
            /// <para>The list of check content.</para>
            /// </summary>
            [NameInMap("Grids")]
            [Validation(Required=false)]
            public List<DescribeCheckWarningDetailResponseBodyCheckDetailColumnsGrids> Grids { get; set; }
            public class DescribeCheckWarningDetailResponseBodyCheckDetailColumnsGrids : TeaModel {
                /// <summary>
                /// <para>The key of the check content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Username</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The display name that corresponds to the key of the check content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UserName</para>
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// <para>The display type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>grid</b>: grid</description></item>
                /// <item><description><b>text</b>: text.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The key of the check content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Containername</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The display name that corresponds to the key of the check content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ContainerName</para>
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            /// <summary>
            /// <para>The display type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>grid</b>: grid</description></item>
            /// <item><description><b>text</b>: text.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the check item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>946</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// <para>The supplementary description of the baseline check risk item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The redis port is open to the outside world and there is no authentication option configured. In addition to directly obtaining all the information in the database, unauthorized users can also attack the system through unauthorized access vulnerability.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the check item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Redis unauthorized access</para>
        /// </summary>
        [NameInMap("Item")]
        [Validation(Required=false)]
        public string Item { get; set; }

        /// <summary>
        /// <para>The risk level of the check item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>high</b>: High risk, highlighted in red.</para>
        /// </description></item>
        /// <item><description><para><b>medium</b>: Medium risk, highlighted in orange.</para>
        /// </description></item>
        /// <item><description><para><b>low</b>: Low risk, highlighted in gray.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The check prompt for the baseline check risk item.</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each request. You can use the request ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE120DAB-F4E7-4C53-ADC3-A97578ABF384</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The type of the baseline check item.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeRiskType~~">DescribeRiskType</a> operation to view all baseline types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Security audit</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
