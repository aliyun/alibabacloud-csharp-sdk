// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ChannelCorpCreateRequest : TeaModel {
        /// <summary>
        /// <para>The counterpart enterprise administrator email address.
        /// ⚠️Either the phone number or this field is required. When this field is specified, the enterprise defaults to email activation.</para>
        /// </summary>
        [NameInMap("administrator_email")]
        [Validation(Required=false)]
        public string AdministratorEmail { get; set; }

        /// <summary>
        /// <para>The name of the counterpart enterprise administrator.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("administrator_name")]
        [Validation(Required=false)]
        public string AdministratorName { get; set; }

        /// <summary>
        /// <para>The phone number of the counterpart enterprise administrator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>131****8888</para>
        /// </summary>
        [NameInMap("administrator_phone")]
        [Validation(Required=false)]
        public string AdministratorPhone { get; set; }

        /// <summary>
        /// <para>The enterprise base currency (settlement currency). Required when btrip_region is GLOBAL. Not used when btrip_region is CN. Valid values:
        /// ● USD: US dollar.
        /// ● HKD: Hong Kong dollar.</para>
        /// </summary>
        [NameInMap("base_currency")]
        [Validation(Required=false)]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// <para>The Alibaba Business Travel region version. Select GLOBAL for enterprises that do not settle in RMB. Valid values:
        /// ● CN: Chinese mainland edition.
        /// ● GLOBAL: Global edition.
        /// ⚠️Default value: CN.</para>
        /// </summary>
        [NameInMap("btrip_region")]
        [Validation(Required=false)]
        public string BtripRegion { get; set; }

        /// <summary>
        /// <para>The city where the counterpart enterprise is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州市</para>
        /// </summary>
        [NameInMap("city")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>The custom business travel enterprise name of the counterpart.</para>
        /// <list type="bullet">
        /// <item><description>Character length limit: 5 ≤ length ≤ 20.</description></item>
        /// <item><description>Use the actual enterprise name of the counterpart.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里巴巴有限公司</para>
        /// </summary>
        [NameInMap("corp_name")]
        [Validation(Required=false)]
        public string CorpName { get; set; }

        /// <summary>
        /// <para>The custom English name of the counterpart business travel enterprise, used for the internationalized version display.</para>
        /// </summary>
        [NameInMap("corp_name_en")]
        [Validation(Required=false)]
        public string CorpNameEn { get; set; }

        /// <summary>
        /// <para>A JSON string with key-value pairs where both key and value are strings.</para>
        /// </summary>
        [NameInMap("extend_field")]
        [Validation(Required=false)]
        public string ExtendField { get; set; }

        /// <summary>
        /// <para>The province where the counterpart enterprise is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>浙江省</para>
        /// </summary>
        [NameInMap("province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <para>The travel scale of the counterpart.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public int? Scope { get; set; }

        /// <summary>
        /// <para>The custom business travel enterprise ID of the counterpart.</para>
        /// <list type="bullet">
        /// <item><description>Character length limit: 5 ≤ length ≤ 20.</description></item>
        /// <item><description>Use the counterpart name plus a number, such as fliggy_001.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fliggy_001</para>
        /// </summary>
        [NameInMap("third_corp_id")]
        [Validation(Required=false)]
        public string ThirdCorpId { get; set; }

        /// <summary>
        /// <para>The user ID of the counterpart enterprise. This parameter is optional. If not specified, the system automatically generates one.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_1234</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
