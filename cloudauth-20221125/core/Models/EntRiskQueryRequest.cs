// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20221125.Models
{
    public class EntRiskQueryRequest : TeaModel {
        /// <summary>
        /// <para>A unique business identifier defined by the merchant side, used for subsequent problem localization and troubleshooting. Supports a combination of 32 alphanumeric characters, please ensure uniqueness.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32198****193000</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>A custom user ID in your business, used for subsequent problem localization and troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <para>Parameter type.
        /// 00: Company name;
        /// 01: Business registration number;
        /// 02: Unified Social Credit Code;
        /// 03: Organization code;</para>
        /// 
        /// <b>Example:</b>
        /// <para>00</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// <para>Enter one of the following based on the ParamType: company name, business registration number, unified social credit code, or organization code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91330106673959****</para>
        /// </summary>
        [NameInMap("ParamValue")]
        [Validation(Required=false)]
        public string ParamValue { get; set; }

        /// <summary>
        /// <para>Custom scene code, used to distinguish business scenarios, a 10-digit number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000086</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <para>Whether user authorization is obtained.
        /// 1: Authorized
        /// 0: Not authorized</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserAuthorization")]
        [Validation(Required=false)]
        public string UserAuthorization { get; set; }

    }

}
