// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryRegistrantProfilesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query the default profile. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <para>Default value: <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DefaultRegistrantProfile")]
        [Validation(Required=false)]
        public bool? DefaultRegistrantProfile { get; set; }

        /// <summary>
        /// <para>The email address of the domain name registrant.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The language of the error message to return if the request fails. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// <para>Default value: <b>en</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>0</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>0</b>. Maximum value: <b>5000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The state of real-name verification for the domain name registrant. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FAILED</b>: Real-name verification for the domain name fails.</description></item>
        /// <item><description><b>SUCCEED</b>: Real-name verification for the domain name is successful.</description></item>
        /// <item><description><b>NONAUDIT</b>: Real-name verification for the domain name is not performed.</description></item>
        /// <item><description><b>AUDITING</b>: Real-name verification for the domain name is in progress.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCEED</para>
        /// </summary>
        [NameInMap("RealNameStatus")]
        [Validation(Required=false)]
        public string RealNameStatus { get; set; }

        /// <summary>
        /// <para>The name of the domain name registrant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>li si</para>
        /// </summary>
        [NameInMap("RegistrantOrganization")]
        [Validation(Required=false)]
        public string RegistrantOrganization { get; set; }

        /// <summary>
        /// <para>The ID of the registrant profile that you want to query. The system generates an ID after you create a registrant profile.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("RegistrantProfileId")]
        [Validation(Required=false)]
        public long? RegistrantProfileId { get; set; }

        /// <summary>
        /// <para>The type of the registrant profile. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>common</b>: common profile.</description></item>
        /// <item><description><b>cnnic</b>: China Internet Network Information Center (CNNIC) profile.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Only the Alibaba Cloud international site (alibabacloud.com) supports CNNIC profiles. To register domain names provided by CNNIC such as the .cn and . domain names on the Alibaba Cloud international site, you must use a CNNIC profile. To register other domain names, use a common profile.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>common</para>
        /// </summary>
        [NameInMap("RegistrantProfileType")]
        [Validation(Required=false)]
        public string RegistrantProfileType { get; set; }

        /// <summary>
        /// <para>The type of the domain name registrant. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: individual.</description></item>
        /// <item><description><b>2</b>: enterprise.</description></item>
        /// </list>
        /// <para>Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RegistrantType")]
        [Validation(Required=false)]
        public string RegistrantType { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test domain name</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The IP address of the client. Set the value to 127.0.0.1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <para>The Chinese name of the domain name registrant.</para>
        /// </summary>
        [NameInMap("ZhRegistrantOrganization")]
        [Validation(Required=false)]
        public string ZhRegistrantOrganization { get; set; }

    }

}
