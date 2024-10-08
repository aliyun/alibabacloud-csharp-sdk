// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetStackResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B34C3A43-A901-5F94-9DAD-758CE4******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information of the method stack.</para>
        /// </summary>
        [NameInMap("StackInfo")]
        [Validation(Required=false)]
        public List<GetStackResponseBodyStackInfo> StackInfo { get; set; }
        public class GetStackResponseBodyStackInfo : TeaModel {
            /// <summary>
            /// <para>The name of the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tomcat Servlet Process</para>
            /// </summary>
            [NameInMap("Api")]
            [Validation(Required=false)]
            public string Api { get; set; }

            [NameInMap("CallCount")]
            [Validation(Required=false)]
            public string CallCount { get; set; }

            /// <summary>
            /// <para>The duration. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>java.lang.NullPointerException</para>
            /// </summary>
            [NameInMap("Exception")]
            [Validation(Required=false)]
            public string Exception { get; set; }

            /// <summary>
            /// <para>The information about the array object.</para>
            /// </summary>
            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public GetStackResponseBodyStackInfoExtInfo ExtInfo { get; set; }
            public class GetStackResponseBodyStackInfoExtInfo : TeaModel {
                /// <summary>
                /// <para>The content of the custom parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>input=254275&amp;</para>
                /// </summary>
                [NameInMap("Info")]
                [Validation(Required=false)]
                public string Info { get; set; }

                /// <summary>
                /// <para>The type of the custom parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>41</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The number of rows in the method stack information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>34</para>
            /// </summary>
            [NameInMap("Line")]
            [Validation(Required=false)]
            public string Line { get; set; }

            /// <summary>
            /// <para>The ID of the RPC mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("RpcId")]
            [Validation(Required=false)]
            public string RpcId { get; set; }

            /// <summary>
            /// <para>The name of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/com/test</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The start time of the call method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1653555396</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

    }

}
