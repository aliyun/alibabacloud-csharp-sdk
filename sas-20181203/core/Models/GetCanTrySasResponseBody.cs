// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCanTrySasResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCanTrySasResponseBodyData Data { get; set; }
        public class GetCanTrySasResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the user is qualified for the trial use. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanTry")]
            [Validation(Required=false)]
            public int? CanTry { get; set; }

            /// <summary>
            /// <para>The editions that are allowed for the trial use.</para>
            /// </summary>
            [NameInMap("CanTryVersions")]
            [Validation(Required=false)]
            public List<int?> CanTryVersions { get; set; }

            /// <summary>
            /// <para>The trial type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: trial prohibited</description></item>
            /// <item><description><b>1</b>: first trial</description></item>
            /// <item><description><b>2</b>: second trial</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TryType")]
            [Validation(Required=false)]
            public int? TryType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8BAA57***B7073A5C1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
