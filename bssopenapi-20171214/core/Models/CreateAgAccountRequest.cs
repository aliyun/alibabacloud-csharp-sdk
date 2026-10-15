// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class CreateAgAccountRequest : TeaModel {
        /// <summary>
        /// <para>The properties of the new account. In the console, click Account Properties in the top menu bar to go to the <b>Security Settings</b> page and view the properties.</para>
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
        /// <para>北京</para>
        /// </summary>
        [NameInMap("CityName")]
        [Validation(Required=false)]
        public string CityName { get; set; }

        /// <summary>
        /// <para>The name of the enterprise. This is the enterprise name that corresponds to the Unified Social Credit Code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云测试有限公司</para>
        /// </summary>
        [NameInMap("EnterpriseName")]
        [Validation(Required=false)]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// <para>The first name of the user under the level 1 category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>志成</para>
        /// </summary>
        [NameInMap("FirstName")]
        [Validation(Required=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// <para>The last name of the user.</para>
        /// <para>Maximum length: 64 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>吴</para>
        /// </summary>
        [NameInMap("LastName")]
        [Validation(Required=false)]
        public string LastName { get; set; }

        /// <summary>
        /// <para>The logon email address of the member account.</para>
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
        /// <para>北京</para>
        /// </summary>
        [NameInMap("ProvinceName")]
        [Validation(Required=false)]
        public string ProvinceName { get; set; }

    }

}
