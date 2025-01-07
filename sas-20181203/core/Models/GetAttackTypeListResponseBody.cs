// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAttackTypeListResponseBody : TeaModel {
        /// <summary>
        /// <para>The attack types.</para>
        /// </summary>
        [NameInMap("AttackTypeList")]
        [Validation(Required=false)]
        public List<GetAttackTypeListResponseBodyAttackTypeList> AttackTypeList { get; set; }
        public class GetAttackTypeListResponseBodyAttackTypeList : TeaModel {
            /// <summary>
            /// <para>The description of the attack type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas.attack.type.type12</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The attack source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cfw</b>: Cloud Firewall</description></item>
            /// <item><description><b>alinet</b>: network defense plug-in</description></item>
            /// <item><description><b>waf</b>: Web Application Firewall (WAF)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>alinet</para>
            /// </summary>
            [NameInMap("Status_Type")]
            [Validation(Required=false)]
            public string StatusType { get; set; }

            /// <summary>
            /// <para>The value of the attack type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>upload</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE500770-42D3-442E-9DDD-156E0F9F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
