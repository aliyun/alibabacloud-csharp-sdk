// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateStandardGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID. You can use the request ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E1D2B4D-3E53-4ABC-999D-1D2520B3471A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the security rule set.</para>
        /// </summary>
        [NameInMap("StandardGroup")]
        [Validation(Required=false)]
        public UpdateStandardGroupResponseBodyStandardGroup StandardGroup { get; set; }
        public class UpdateStandardGroupResponseBodyStandardGroup : TeaModel {
            /// <summary>
            /// <para>The type of the database for which the security rules are used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The description of the security rule set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Production Environment test rules</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The security rule set ID.</para>
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
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
