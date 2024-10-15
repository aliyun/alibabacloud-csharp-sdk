// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class GroupUserSaveShrinkRequest : TeaModel {
        [NameInMap("base_city_code")]
        [Validation(Required=false)]
        public string BaseCityCode { get; set; }

        [NameInMap("birthday")]
        [Validation(Required=false)]
        public string Birthday { get; set; }

        [NameInMap("cert_list")]
        [Validation(Required=false)]
        public string CertListShrink { get; set; }

        [NameInMap("gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("job_no")]
        [Validation(Required=false)]
        public string JobNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18000000000</para>
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ce/shi</para>
        /// </summary>
        [NameInMap("real_name_en")]
        [Validation(Required=false)]
        public string RealNameEn { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sub_corp_id_list")]
        [Validation(Required=false)]
        public string SubCorpIdListShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
