// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckStandardResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FA91FBDA-***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The standards.</para>
        /// </summary>
        [NameInMap("Standards")]
        [Validation(Required=false)]
        public List<ListCheckStandardResponseBodyStandards> Standards { get; set; }
        public class ListCheckStandardResponseBodyStandards : TeaModel {
            /// <summary>
            /// <para>The cloud service provider that uses the standard. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Alibaba Cloud.</description></item>
            /// <item><description><b>3</b>: Tencent Cloud.</description></item>
            /// <item><description><b>4</b>: Huawei Cloud.</description></item>
            /// <item><description><b>5</b>: Microsoft Azure.</description></item>
            /// <item><description><b>7</b>: AWS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("BindVendor")]
            [Validation(Required=false)]
            public int? BindVendor { get; set; }

            /// <summary>
            /// <para>The ID of the standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The requirements.</para>
            /// </summary>
            [NameInMap("Requirements")]
            [Validation(Required=false)]
            public List<ListCheckStandardResponseBodyStandardsRequirements> Requirements { get; set; }
            public class ListCheckStandardResponseBodyStandardsRequirements : TeaModel {
                /// <summary>
                /// <para>The ID of the requirement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The number of check items in the requirement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("RiskCheckCount")]
                [Validation(Required=false)]
                public long? RiskCheckCount { get; set; }

                /// <summary>
                /// <para>The display name of the search condition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RAM identity authentication</para>
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// <para>The priority for display.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ShowPriorityLevel")]
                [Validation(Required=false)]
                public int? ShowPriorityLevel { get; set; }

            }

            /// <summary>
            /// <para>The display name of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Identity and permission management</para>
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            /// <summary>
            /// <para>The priority for display.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ShowPriorityLevel")]
            [Validation(Required=false)]
            public int? ShowPriorityLevel { get; set; }

            /// <summary>
            /// <para>The type of the standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IDENTITY_PERMISSION</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
