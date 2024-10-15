// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ChannelCorpCreateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("administrator_name")]
        [Validation(Required=false)]
        public string AdministratorName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18378889782</para>
        /// </summary>
        [NameInMap("administrator_phone")]
        [Validation(Required=false)]
        public string AdministratorPhone { get; set; }

        [NameInMap("city")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("corp_name")]
        [Validation(Required=false)]
        public string CorpName { get; set; }

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

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
