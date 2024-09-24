// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeNsasSuspEventTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the information about the alert type.</para>
        /// </summary>
        [NameInMap("EventTypes")]
        [Validation(Required=false)]
        public List<DescribeNsasSuspEventTypeResponseBodyEventTypes> EventTypes { get; set; }
        public class DescribeNsasSuspEventTypeResponseBodyEventTypes : TeaModel {
            /// <summary>
            /// <para>The name of the alert type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unusual Logon</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The number of assets for which an alert of the type is generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("SuspEventCount")]
            [Validation(Required=false)]
            public int? SuspEventCount { get; set; }

            /// <summary>
            /// <para>The alert type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unusual Logon</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9FBC6E47-7508-58C9-9E76-528E118CB1CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
