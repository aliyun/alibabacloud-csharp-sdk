// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetProxyAccessResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserNotExist</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified user not exists.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The authorization information about the secure access proxy feature.</para>
        /// </summary>
        [NameInMap("ProxyAccess")]
        [Validation(Required=false)]
        public GetProxyAccessResponseBodyProxyAccess ProxyAccess { get; set; }
        public class GetProxyAccessResponseBodyProxyAccess : TeaModel {
            /// <summary>
            /// <para>The username of the database account that is authorized to enable the secure access proxy feature for an instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hObpgEXoca42q***</para>
            /// </summary>
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }

            /// <summary>
            /// <para>The time when the user is authorized to enable the secure access proxy feature for an instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1643034647</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The username of the independent database account.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("IndepAccount")]
            [Validation(Required=false)]
            public string IndepAccount { get; set; }

            /// <summary>
            /// <para>The ID of the instance for which the secure access proxy feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1922545</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>The method that is used to authorize the user to enable the secure access proxy feature for an instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Authorization by the Alibaba Cloud Account ()</b>: The information in the parentheses () indicates the ID of the Alibaba Cloud account.</description></item>
            /// <item><description><b>Authorization by submitting the ticket ()</b>:The information in the parentheses () indicates the number of the ticket that the user submits to apply for permissions.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Authorization by the Alibaba Cloud account (29490401597700\<em>\</em>\<em>\</em>)</para>
            /// </summary>
            [NameInMap("OriginInfo")]
            [Validation(Required=false)]
            public string OriginInfo { get; set; }

            /// <summary>
            /// <para>The ID that DMS generates after the user is authorized to enable the secure access proxy feature for an instance. The ID is unique in DMS. You can call the <a href="https://help.aliyun.com/document_detail/295386.html">ListProxyAccesses</a> operation to query the ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2002</para>
            /// </summary>
            [NameInMap("ProxyAccessId")]
            [Validation(Required=false)]
            public long? ProxyAccessId { get; set; }

            /// <summary>
            /// <para>The ID of the secure access proxy.</para>
            /// <remarks>
            /// <para> You can call the <a href="https://help.aliyun.com/document_detail/295371.html">ListProxies</a> operation to query the ID of the secure access proxy.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1905</para>
            /// </summary>
            [NameInMap("ProxyId")]
            [Validation(Required=false)]
            public long? ProxyId { get; set; }

            /// <summary>
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12***</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            /// <summary>
            /// <para>The nickname of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25936669186260****</para>
            /// </summary>
            [NameInMap("UserUid")]
            [Validation(Required=false)]
            public string UserUid { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3CDB8601-AD74-4A47-8114-08E08CD6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
