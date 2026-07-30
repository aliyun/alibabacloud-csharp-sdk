// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyListQueryRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to include reimbursed application forms. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: Unreimbursed application forms.</description></item>
        /// <item><description>true: Reimbursed application forms.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("all_apply")]
        [Validation(Required=false)]
        public bool? AllApply { get; set; }

        /// <summary>
        /// <para>The department ID of the applicant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dept1</para>
        /// </summary>
        [NameInMap("depart_id")]
        [Validation(Required=false)]
        public string DepartId { get; set; }

        /// <summary>
        /// <para>The end time in the format of yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-05-01 00:00:00</para>
        /// </summary>
        [NameInMap("end_time")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The approval forms with an update time greater than or equal to this time. Format: yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-05-01 00:00:00</para>
        /// </summary>
        [NameInMap("gmt_modified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only business travel application forms. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Business travel application forms only.</description></item>
        /// <item><description>false: All application forms.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("only_shang_lv_apply")]
        [Validation(Required=false)]
        public bool? OnlyShangLvApply { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start time in the format of yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-05-01 00:00:00</para>
        /// </summary>
        [NameInMap("start_time")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

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
        /// <para>The submission type of the application form. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Submitted on behalf of another person.</description></item>
        /// <item><description>2: Submitted by the applicant.</description></item>
        /// </list>
        /// <para>Note: When the application form is submitted on behalf of another person, the submitter cannot place orders for themselves.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// <para>The third-party associated order number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abs123</para>
        /// </summary>
        [NameInMap("union_no")]
        [Validation(Required=false)]
        public string UnionNo { get; set; }

        /// <summary>
        /// <para>The applicant ID (third-party user ID).</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
