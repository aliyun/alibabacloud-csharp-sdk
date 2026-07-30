// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class QueryCorpDetailInfoRequest : TeaModel {
        /// <summary>
        /// <para>The Taobao account ID.</para>
        /// <list type="bullet">
        /// <item><description>Used in combination with the third-party enterprise ID to query enterprise information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2210********668</para>
        /// </summary>
        [NameInMap("account_id")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The ID of the business travel enterprise to query.</para>
        /// <list type="bullet">
        /// <item><description>You can only query information about enterprises that your application is authorized to access.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>btripxxxxxx</para>
        /// </summary>
        [NameInMap("target_corp_id")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

        /// <summary>
        /// <para>The third-party enterprise ID to query.</para>
        /// <list type="bullet">
        /// <item><description><para>You can only query information about enterprises that your application is authorized to access.</para>
        /// </description></item>
        /// <item><description><para>When querying by third-party enterprise ID, the Taobao account ID is required.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>alibabaxxxxxxx</para>
        /// </summary>
        [NameInMap("target_third_corp_id")]
        [Validation(Required=false)]
        public string TargetThirdCorpId { get; set; }

    }

}
