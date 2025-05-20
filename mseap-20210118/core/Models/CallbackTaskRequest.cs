// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mseap20210118.Models
{
    public class CallbackTaskRequest : TeaModel {
        /// <summary>
        /// <para>aliyunKp</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AliyunKp")]
        [Validation(Required=false)]
        public string AliyunKp { get; set; }

        /// <summary>
        /// <para>apiType</para>
        /// 
        /// <b>Example:</b>
        /// <para>MPC</para>
        /// </summary>
        [NameInMap("ApiType")]
        [Validation(Required=false)]
        public string ApiType { get; set; }

        /// <summary>
        /// <para>bid</para>
        /// 
        /// <b>Example:</b>
        /// <para>26842</para>
        /// </summary>
        [NameInMap("Bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <para>lang</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>orderId</para>
        /// 
        /// <b>Example:</b>
        /// <para>1672369049358</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>originalRequest</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OriginalRequest")]
        [Validation(Required=false)]
        public string OriginalRequest { get; set; }

        /// <summary>
        /// <para>outTaskId</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OutTaskId")]
        [Validation(Required=false)]
        public string OutTaskId { get; set; }

        [NameInMap("PrincipalKey")]
        [Validation(Required=false)]
        public string PrincipalKey { get; set; }

        /// <summary>
        /// <para>taskData</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;result\&quot;:\&quot;SUCCESS\&quot;,\&quot;message\&quot;:\&quot;null\&quot;,\&quot;taskId\&quot;:\&quot;8cbc97d8-9b2b-4c2f-862f-983ea5dbedc2\&quot;}</para>
        /// </summary>
        [NameInMap("TaskData")]
        [Validation(Required=false)]
        public string TaskData { get; set; }

        /// <summary>
        /// <para>taskId</para>
        /// 
        /// <b>Example:</b>
        /// <para>2559492</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>taskType</para>
        /// 
        /// <b>Example:</b>
        /// <para>PATENT_QUERY</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>userAccessKeyId</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserAccessKeyId")]
        [Validation(Required=false)]
        public string UserAccessKeyId { get; set; }

        /// <summary>
        /// <para>userBid</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserBid")]
        [Validation(Required=false)]
        public string UserBid { get; set; }

        /// <summary>
        /// <para>userCallerParentId</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserCallerParentId")]
        [Validation(Required=false)]
        public long? UserCallerParentId { get; set; }

        /// <summary>
        /// <para>userCallerSecurityTransport</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserCallerSecurityTransport")]
        [Validation(Required=false)]
        public bool? UserCallerSecurityTransport { get; set; }

        /// <summary>
        /// <para>userCallerType</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserCallerType")]
        [Validation(Required=false)]
        public string UserCallerType { get; set; }

        /// <summary>
        /// <para>userClientIp</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <para>userKp</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserKp")]
        [Validation(Required=false)]
        public string UserKp { get; set; }

        /// <summary>
        /// <para>userMfaPresent</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserMfaPresent")]
        [Validation(Required=false)]
        public bool? UserMfaPresent { get; set; }

        /// <summary>
        /// <para>userSecurityToken</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserSecurityToken")]
        [Validation(Required=false)]
        public string UserSecurityToken { get; set; }

    }

}
