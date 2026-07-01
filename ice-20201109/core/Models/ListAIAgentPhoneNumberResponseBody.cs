// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListAIAgentPhoneNumberResponseBody : TeaModel {
        /// <summary>
        /// <para>Array of returned Data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAIAgentPhoneNumberResponseBodyData> Data { get; set; }
        public class ListAIAgentPhoneNumberResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>132*****683</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// <para>Phone number status.</para>
            /// <list type="bullet">
            /// <item><description><para>1: &quot;Activation in progress&quot;.</para>
            /// </description></item>
            /// <item><description><para>2: &quot;Normal&quot;.</para>
            /// </description></item>
            /// <item><description><para>3: &quot;Deactivation in progress&quot;.</para>
            /// </description></item>
            /// <item><description><para>4: &quot;Deactivated&quot;.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>Page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of records returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>******<b><b><b>16-412C-B127-</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of phone numbers found in the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>186</para>
        /// </summary>
        [NameInMap("TotalNumber")]
        [Validation(Required=false)]
        public int? TotalNumber { get; set; }

    }

}
