// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListProxyAccessesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MissingProxyId</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ProxyId is mandatory for this action.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The information about the users that are authorized to access the database instance by using the secure access proxy feature.</para>
        /// </summary>
        [NameInMap("ProxyAccessList")]
        [Validation(Required=false)]
        public List<ListProxyAccessesResponseBodyProxyAccessList> ProxyAccessList { get; set; }
        public class ListProxyAccessesResponseBodyProxyAccessList : TeaModel {
            /// <summary>
            /// <para>The username of the database account that is authorized to access the database instance by using the secure access proxy feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MXPL8HalI22m****</para>
            /// </summary>
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }

            /// <summary>
            /// <para>The time when the user is authorized to access the database instance by using the secure access proxy feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-31 10:34:18</para>
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
            /// <para>The ID of the database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>164****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>The method that is used to authorize the user to access the database instance by using the secure access proxy feature. Valid values: </para>
            /// <list type="bullet">
            /// <item><description><b>Authorization by the Alibaba Cloud Account ()</b>: The information in the parentheses () indicates the user ID (UID) of the Alibaba Cloud account.</description></item>
            /// <item><description><b>Authorization by submitting the ticket ()</b>:The information in the parentheses () indicates the number of the ticket that the user submits to apply for permissions.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Authorization by the Alibaba Cloud Account(29490401597700****)</para>
            /// </summary>
            [NameInMap("OriginInfo")]
            [Validation(Required=false)]
            public string OriginInfo { get; set; }

            /// <summary>
            /// <para>The ID that DMS generates after the user is authorized to access the database instance by using the secure access proxy feature. The ID is unique in DMS.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("ProxyAccessId")]
            [Validation(Required=false)]
            public long? ProxyAccessId { get; set; }

            /// <summary>
            /// <para>The ID of the secure access proxy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47</para>
            /// </summary>
            [NameInMap("ProxyId")]
            [Validation(Required=false)]
            public long? ProxyId { get; set; }

            /// <summary>
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26****</para>
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
            /// <para>The UID of the Alibaba Cloud account.</para>
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
        /// <para>E53D178A-85E9-5E1F-88B6-3CB1FCF2****</para>
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
