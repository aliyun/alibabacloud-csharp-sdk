// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class HotlineSessionQueryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>7719786****</para>
        /// </summary>
        [NameInMap("Acid")]
        [Validation(Required=false)]
        public string Acid { get; set; }

        [NameInMap("AcidList")]
        [Validation(Required=false)]
        public List<string> AcidList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("CallResult")]
        [Validation(Required=false)]
        public string CallResult { get; set; }

        [NameInMap("CallResultList")]
        [Validation(Required=false)]
        public List<string> CallResultList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CallType")]
        [Validation(Required=false)]
        public int? CallType { get; set; }

        [NameInMap("CallTypeList")]
        [Validation(Required=false)]
        public List<int?> CallTypeList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>135615****</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        [NameInMap("CalledNumberList")]
        [Validation(Required=false)]
        public List<string> CalledNumberList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>057177****</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumber { get; set; }

        [NameInMap("CallingNumberList")]
        [Validation(Required=false)]
        public List<string> CallingNumberList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("GroupIdList")]
        [Validation(Required=false)]
        public List<long?> GroupIdList { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acc1c58dab4a4dd280e3813c66</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7856****</para>
        /// </summary>
        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        [NameInMap("MemberIdList")]
        [Validation(Required=false)]
        public List<string> MemberIdList { get; set; }

        [NameInMap("MemberName")]
        [Validation(Required=false)]
        public string MemberName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>161482972</para>
        /// </summary>
        [NameInMap("QueryEndTime")]
        [Validation(Required=false)]
        public long? QueryEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>161482872</para>
        /// </summary>
        [NameInMap("QueryStartTime")]
        [Validation(Required=false)]
        public long? QueryStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>555555</para>
        /// </summary>
        [NameInMap("ServicerId")]
        [Validation(Required=false)]
        public string ServicerId { get; set; }

        [NameInMap("ServicerIdList")]
        [Validation(Required=false)]
        public List<string> ServicerIdList { get; set; }

        [NameInMap("ServicerName")]
        [Validation(Required=false)]
        public string ServicerName { get; set; }

    }

}
