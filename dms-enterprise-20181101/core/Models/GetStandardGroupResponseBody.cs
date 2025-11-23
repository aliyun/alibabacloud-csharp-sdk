// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetStandardGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code that is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message that is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BF7E9543-F431-566A-991A-B5C493EA36C2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the security rule set.</para>
        /// </summary>
        [NameInMap("StandardGroup")]
        [Validation(Required=false)]
        public GetStandardGroupResponseBodyStandardGroup StandardGroup { get; set; }
        public class GetStandardGroupResponseBodyStandardGroup : TeaModel {
            /// <summary>
            /// <para>The engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The description of the security rule set.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the security rule set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>41****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <para>The control mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NONE_CONTROL</b>: Flexible Management</description></item>
            /// <item><description><b>STABLE</b>: Stable Change</description></item>
            /// <item><description><b>COMMON</b>: Security Collaboration</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMMON</para>
            /// </summary>
            [NameInMap("GroupMode")]
            [Validation(Required=false)]
            public string GroupMode { get; set; }

            /// <summary>
            /// <para>The name of the security rule set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>poc_test</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The ID of the user who last modified the security rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>51****</para>
            /// </summary>
            [NameInMap("LastMenderId")]
            [Validation(Required=false)]
            public long? LastMenderId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
