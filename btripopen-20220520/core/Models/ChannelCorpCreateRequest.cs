// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ChannelCorpCreateRequest : TeaModel {
        [NameInMap("administrator_email")]
        [Validation(Required=false)]
        public string AdministratorEmail { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("administrator_name")]
        [Validation(Required=false)]
        public string AdministratorName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18378889782</para>
        /// </summary>
        [NameInMap("administrator_phone")]
        [Validation(Required=false)]
        public string AdministratorPhone { get; set; }

        [NameInMap("base_currency")]
        [Validation(Required=false)]
        public string BaseCurrency { get; set; }

        [NameInMap("btrip_region")]
        [Validation(Required=false)]
        public string BtripRegion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>杭州市</para>
        /// </summary>
        [NameInMap("city")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里巴巴有限公司</para>
        /// </summary>
        [NameInMap("corp_name")]
        [Validation(Required=false)]
        public string CorpName { get; set; }

        [NameInMap("corp_name_en")]
        [Validation(Required=false)]
        public string CorpNameEn { get; set; }

        [NameInMap("extend_field")]
        [Validation(Required=false)]
        public string ExtendField { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>浙江省</para>
        /// </summary>
        [NameInMap("province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public int? Scope { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00001</para>
        /// </summary>
        [NameInMap("third_corp_id")]
        [Validation(Required=false)]
        public string ThirdCorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user_1234</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
