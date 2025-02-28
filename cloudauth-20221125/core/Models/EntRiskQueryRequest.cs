// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20221125.Models
{
    public class EntRiskQueryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>32198****193000</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>00</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>91330106673959****</para>
        /// </summary>
        [NameInMap("ParamValue")]
        [Validation(Required=false)]
        public string ParamValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000000086</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserAuthorization")]
        [Validation(Required=false)]
        public string UserAuthorization { get; set; }

    }

}
