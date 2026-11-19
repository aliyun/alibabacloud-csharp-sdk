// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class CreateAgAccountRequest : TeaModel {
        /// <summary>
        /// <para>The attributes of the new account. To view the attributes, click Account Attributes in the top menu bar of the console to go to the <b>Security Settings</b> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AccountAttr")]
        [Validation(Required=false)]
        public string AccountAttr { get; set; }

        /// <summary>
        /// <para>The name of the city in English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Beijing</para>
        /// </summary>
        [NameInMap("CityName")]
        [Validation(Required=false)]
        public string CityName { get; set; }

        /// <summary>
        /// <para>The name of the enterprise. The name must be the same as the enterprise name associated with the unified social credit code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud Test Co., Ltd</para>
        /// </summary>
        [NameInMap("EnterpriseName")]
        [Validation(Required=false)]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// <para>The name of the first-level category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhicheng</para>
        /// </summary>
        [NameInMap("FirstName")]
        [Validation(Required=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// <para>The last name of the user.</para>
        /// <para>Maximum length: 64 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Wu</para>
        /// </summary>
        [NameInMap("LastName")]
        [Validation(Required=false)]
        public string LastName { get; set; }

        /// <summary>
        /// <para>The logon email address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>email</para>
        /// </summary>
        [NameInMap("LoginEmail")]
        [Validation(Required=false)]
        public string LoginEmail { get; set; }

        /// <summary>
        /// <para>The country code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("NationCode")]
        [Validation(Required=false)]
        public string NationCode { get; set; }

        /// <summary>
        /// <para>The postal code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>350000</para>
        /// </summary>
        [NameInMap("Postcode")]
        [Validation(Required=false)]
        public string Postcode { get; set; }

        /// <summary>
        /// <para>The name of the province. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Beijing</para>
        /// </summary>
        [NameInMap("ProvinceName")]
        [Validation(Required=false)]
        public string ProvinceName { get; set; }

    }

}
