// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckWarningDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The suggestion for the management of the risk item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You can fix it in the following ways:↵1. To configure authentication for redis service, click the redis.conf Configure complex password in requirepass, and then restart redis.↵2. In redis configuration file redis.conf The configuration is as follows: bind 127.0.0.1, only allow local access, and then restart redis</para>
        /// </summary>
        [NameInMap("Advice")]
        [Validation(Required=false)]
        public string Advice { get; set; }

        /// <summary>
        /// <para>List of asset details to check.</para>
        /// </summary>
        [NameInMap("CheckDetailAssetInfo")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> CheckDetailAssetInfo { get; set; }

        /// <summary>
        /// <para>Detection content details.</para>
        /// </summary>
        [NameInMap("CheckDetailColumns")]
        [Validation(Required=false)]
        public List<DescribeCheckWarningDetailResponseBodyCheckDetailColumns> CheckDetailColumns { get; set; }
        public class DescribeCheckWarningDetailResponseBodyCheckDetailColumns : TeaModel {
            /// <summary>
            /// <para>Detection content list.</para>
            /// </summary>
            [NameInMap("Grids")]
            [Validation(Required=false)]
            public List<DescribeCheckWarningDetailResponseBodyCheckDetailColumnsGrids> Grids { get; set; }
            public class DescribeCheckWarningDetailResponseBodyCheckDetailColumnsGrids : TeaModel {
                /// <summary>
                /// <para>Key to detect content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Username</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The detection content key corresponds to the display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UserName</para>
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// <para>Display type. Value:</para>
                /// <list type="bullet">
                /// <item><description><b>grid</b>: Detection grid</description></item>
                /// <item><description><b>text</b>: text</description></item>
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
            /// <para>Key to detect content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Containername</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The detection content key corresponds to the display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ContainerName</para>
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            /// <summary>
            /// <para>Display type. Value:</para>
            /// <list type="bullet">
            /// <item><description><b>grid</b>: Detection grid</description></item>
            /// <item><description><b>text</b>: text</description></item>
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
        /// <para>The additional information about the risk item.</para>
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
        /// <item><description><b>high</b>: The item is a high-risk item and is highlighted in red.</description></item>
        /// <item><description><b>medium</b>: The item is a medium-risk item and is highlighted in orange.</description></item>
        /// <item><description><b>low</b>: The item is a low-risk item and is highlighted in gray.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The prompt for the risk item.</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE120DAB-F4E7-4C53-ADC3-A97578ABF384</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The type of the check item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>hc_exploit</b>: unauthorized access</description></item>
        /// <item><description><b>hc_djbh</b>: classified protection compliance</description></item>
        /// <item><description><b>hc_best_secruity</b>: best security practice</description></item>
        /// <item><description><b>hc_container</b>: container security</description></item>
        /// <item><description><b>hc_custom</b>: custom baseline</description></item>
        /// <item><description><b>cis</b>: Center for Internet Security (CIS) compliance</description></item>
        /// <item><description><b>weak_password</b>: weak password</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hc_exploit</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
