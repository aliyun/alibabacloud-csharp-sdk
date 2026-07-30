// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyQueryRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Business Travel approval form ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("apply_id")]
        [Validation(Required=false)]
        public int? ApplyId { get; set; }

        /// <summary>
        /// <para>The Alibaba Business Travel approval form display ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>201710111505000464651</para>
        /// </summary>
        [NameInMap("apply_show_id")]
        [Validation(Required=false)]
        public string ApplyShowId { get; set; }

        /// <summary>
        /// <para><del>Sub-enterprise ID</del>
        /// Deprecated. Use <a href="/#/document/server/groupcorptoken-group-enterprise-certificate?handbookId=development-support">Group enterprise credential</a> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>btrip123</para>
        /// </summary>
        [NameInMap("sub_corp_id")]
        [Validation(Required=false)]
        public string SubCorpId { get; set; }

        /// <summary>
        /// <para>The third-party approval form ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adczd</para>
        /// </summary>
        [NameInMap("thirdpart_apply_id")]
        [Validation(Required=false)]
        public string ThirdpartApplyId { get; set; }

        /// <summary>
        /// <para>The submission type of the approval form. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Submitted on behalf of another person.</description></item>
        /// <item><description>2: Submitted by the applicant.</description></item>
        /// </list>
        /// <para>Note: When the approval form is submitted on behalf of another person, the submitter cannot place orders for themselves.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
