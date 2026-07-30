// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyApproveRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the external application form.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sdfg</para>
        /// </summary>
        [NameInMap("apply_id")]
        [Validation(Required=false)]
        public string ApplyId { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>同意</para>
        /// </summary>
        [NameInMap("note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        /// <summary>
        /// <para>The time when the operation is performed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-12 16:12:53</para>
        /// </summary>
        [NameInMap("operate_time")]
        [Validation(Required=false)]
        public string OperateTime { get; set; }

        /// <summary>
        /// <para>The status of the approval form. You can change the status to Approved or Rejected only when the current status is Pending Approval. No restrictions apply when you change the status to other values. You cannot directly change the status from Revoked or Rejected to Approved. You must first change the status to Pending Approval before changing it to Approved.</para>
        /// <para>Valid values:</para>
        /// <para>0: Pending approval.</para>
        /// <para>1: Approved.</para>
        /// <para>2: Rejected.</para>
        /// <para>4: Revoked.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para><del>Sub-enterprise ID</del>
        /// Deprecated. Use <a href="/#/document/server/groupcorptoken-group-enterprise-certificate?handbookId=development-support">Group Enterprise Credential</a> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>btrip123</para>
        /// </summary>
        [NameInMap("sub_corp_id")]
        [Validation(Required=false)]
        public string SubCorpId { get; set; }

        /// <summary>
        /// <para>The ID of the approver (third-party user ID).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>thirdpart12138</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The name of the approver.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
