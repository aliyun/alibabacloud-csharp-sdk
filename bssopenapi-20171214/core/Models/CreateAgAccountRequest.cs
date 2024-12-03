// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class CreateAgAccountRequest : TeaModel {
        /// <summary>
        /// <para>The attribute of the account. To view the attribute of the account, use the account to log on to the Alibaba Cloud Management Console, move the pointer over the profile picture in the upper-right corner, and then click <b>Security Settings</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AccountAttr")]
        [Validation(Required=false)]
        public string AccountAttr { get; set; }

        /// <summary>
        /// <para>The name of the city.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Beijing</para>
        /// </summary>
        [NameInMap("CityName")]
        [Validation(Required=false)]
        public string CityName { get; set; }

        /// <summary>
        /// <para>The name of the enterprise.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dongguan ChuangNeng Electric Appliance Co., Ltd</para>
        /// </summary>
        [NameInMap("EnterpriseName")]
        [Validation(Required=false)]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// <para>The first name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhicheng</para>
        /// </summary>
        [NameInMap("FirstName")]
        [Validation(Required=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// <para>The last name.</para>
        /// <para>The last name can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Wu</para>
        /// </summary>
        [NameInMap("LastName")]
        [Validation(Required=false)]
        public string LastName { get; set; }

        /// <summary>
        /// <para>The email address used to log on to the account.</para>
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
        /// <para>The zip code.</para>
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
