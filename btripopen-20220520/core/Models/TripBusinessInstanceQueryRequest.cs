// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TripBusinessInstanceQueryRequest : TeaModel {
        /// <summary>
        /// <para>The approval business instance ID. Either this parameter or the third-party business ID must be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("business_instance_id")]
        [Validation(Required=false)]
        public string BusinessInstanceId { get; set; }

        /// <summary>
        /// <para>The third-party business ID. Either this parameter or the approval instance ID must be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("third_business_id")]
        [Validation(Required=false)]
        public string ThirdBusinessId { get; set; }

        /// <summary>
        /// <para>The user ID of the current operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>thirdpart12138</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The name of the current operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
