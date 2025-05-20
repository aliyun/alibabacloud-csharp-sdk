// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mseap20210118.Models
{
    public class SetRedisValueRequest : TeaModel {
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
        /// <para>part_config_data</para>
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
        /// <b>Example:</b>
        /// <para>1684967696495902</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

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
        /// <para>originalRequest</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OriginalRequest")]
        [Validation(Required=false)]
        public string OriginalRequest { get; set; }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>F864A883-AD76-53D5-9A24-A6DAD5177697</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>timeout</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>259200000</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
