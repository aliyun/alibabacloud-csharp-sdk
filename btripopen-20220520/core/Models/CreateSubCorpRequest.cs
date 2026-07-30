// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CreateSubCorpRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the sub-enterprise created through this operation. Reusing this ID causes the call to fail.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>corp123</para>
        /// </summary>
        [NameInMap("outer_corp_id")]
        [Validation(Required=false)]
        public string OuterCorpId { get; set; }

        /// <summary>
        /// <para>The unique name of the sub-enterprise created through this operation. Reusing this name causes the call to fail.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试企业</para>
        /// </summary>
        [NameInMap("outer_corp_name")]
        [Validation(Required=false)]
        public string OuterCorpName { get; set; }

        /// <summary>
        /// <para>The employee ID that exists in an enterprise that has signed the Alibaba Business Travel Parent Account Agreement.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
