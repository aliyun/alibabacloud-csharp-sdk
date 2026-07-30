// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class GroupUserSaveShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The 6-digit administrative code. A maximum of two codes are supported, separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456,654321</para>
        /// </summary>
        [NameInMap("base_city_code")]
        [Validation(Required=false)]
        public string BaseCityCode { get; set; }

        /// <summary>
        /// <para>The date of birth in the format yyyy-MM-dd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1999-03-12</para>
        /// </summary>
        [NameInMap("birthday")]
        [Validation(Required=false)]
        public string Birthday { get; set; }

        /// <summary>
        /// <para>The list of certificates.</para>
        /// </summary>
        [NameInMap("cert_list")]
        [Validation(Required=false)]
        public string CertListShrink { get; set; }

        /// <summary>
        /// <para>The gender. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>F: female.</description></item>
        /// <item><description>M: male.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>M</para>
        /// </summary>
        [NameInMap("gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        /// <summary>
        /// <para>The employee number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("job_no")]
        [Validation(Required=false)]
        public string JobNo { get; set; }

        /// <summary>
        /// <para>The mobile phone number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18000000000</para>
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <para>The English name. Use &quot;/&quot; as a separator with no spaces. Format: last_name/first_name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ce/shi</para>
        /// </summary>
        [NameInMap("real_name_en")]
        [Validation(Required=false)]
        public string RealNameEn { get; set; }

        /// <summary>
        /// <para>The list of affiliated enterprises.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sub_corp_id_list")]
        [Validation(Required=false)]
        public string SubCorpIdListShrink { get; set; }

        /// <summary>
        /// <para>The employee ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The employee name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
