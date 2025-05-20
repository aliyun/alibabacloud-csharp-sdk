// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mseap20210118.Models
{
    public class PushRpaTaskRequest : TeaModel {
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
        /// <para>public</para>
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
        /// <para>modelId</para>
        /// 
        /// <b>Example:</b>
        /// <para>1951</para>
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public long? ModelId { get; set; }

        /// <summary>
        /// <para>name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
        /// <para>request</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Request")]
        [Validation(Required=false)]
        public string Request { get; set; }

        /// <summary>
        /// <para>status</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>taskId</para>
        /// 
        /// <b>Example:</b>
        /// <para>833812</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>templateId</para>
        /// 
        /// <b>Example:</b>
        /// <para>26</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

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
