// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class CreateAtiRegistrantRequest : TeaModel {
        /// <summary>
        /// <para>The country or region of the registrant. Specify a 2-character country or region code in compliance with GB/T 2659.1-2022.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>中国</para>
        /// </summary>
        [NameInMap("Cc")]
        [Validation(Required=false)]
        public string Cc { get; set; }

        /// <summary>
        /// <para>The city of the registrant. The value cannot exceed 255 characters in length. If the country is China, the value must comply with GB/T 2260-2007.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州市</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>Ensures the idempotency of the request. Generate a unique parameter value from your client to ensure that the value is unique across different requests. The ClientToken value supports only ASCII characters and cannot exceed 64 characters in length.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId may vary for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhbGciOiJIUzI1NiIsInR5cC.....</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The document number of the registrant. The value cannot exceed 50 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110123456789122341</para>
        /// </summary>
        [NameInMap("DocumentCode")]
        [Validation(Required=false)]
        public string DocumentCode { get; set; }

        /// <summary>
        /// <para>The document image of the registrant in Base64 encoding. The original file size must be between 50 KB and 3 MB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>证件图片</para>
        /// </summary>
        [NameInMap("DocumentImage")]
        [Validation(Required=false)]
        public string DocumentImage { get; set; }

        /// <summary>
        /// <para>The document type of the registrant.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Field</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>SFZ</td>
        /// <td>ID card</td>
        /// </tr>
        /// <tr>
        /// <td>HZ</td>
        /// <td>Passport</td>
        /// </tr>
        /// <tr>
        /// <td>ORG</td>
        /// <td>Organization code certificate</td>
        /// </tr>
        /// <tr>
        /// <td>YYZZ</td>
        /// <td>Business license</td>
        /// </tr>
        /// <tr>
        /// <td>BDDM</td>
        /// <td>Military unit code</td>
        /// </tr>
        /// <tr>
        /// <td>CHNSHXYD</td>
        /// <td>Unified Social Credit Code certificate of the People\&quot;s Republic of China</td>
        /// </tr>
        /// <tr>
        /// <td>GAJMTX</td>
        /// <td>Mainland Travel Permit for Hong Kong and Macao Residents</td>
        /// </tr>
        /// <tr>
        /// <td>GAJZZ</td>
        /// <td>Residence Permit for Hong Kong and Macao Residents</td>
        /// </tr>
        /// <tr>
        /// <td>GATLYCZD</td>
        /// <td>Registration certificate for permanent representative offices of tourism departments in Hong Kong, Macao, and Taiwan</td>
        /// </tr>
        /// <tr>
        /// <td>GAXWZNDJ</td>
        /// <td>Registration certificate for permanent mainland journalist stations of Hong Kong and Macao news agencies</td>
        /// </tr>
        /// <tr>
        /// <td>GZJGZY</td>
        /// <td>Notary office practice certificate</td>
        /// </tr>
        /// <tr>
        /// <td>JDDWFW</td>
        /// <td>Military unit paid service license</td>
        /// </tr>
        /// <tr>
        /// <td>JGZ</td>
        /// <td>Military officer certificate</td>
        /// </tr>
        /// <tr>
        /// <td>JJHFR</td>
        /// <td>Foundation legal person registration certificate</td>
        /// </tr>
        /// <tr>
        /// <td>LSZY</td>
        /// <td>Law firm practice license</td>
        /// </tr>
        /// <tr>
        /// <td>MBFQY</td>
        /// <td>Private non-enterprise unit registration certificate</td>
        /// </tr>
        /// <tr>
        /// <td>MBXXBX</td>
        /// <td>Private school operating license</td>
        /// </tr>
        /// <tr>
        /// <td>NCJTJJZZ</td>
        /// <td>Rural collective economic organization registration certificate</td>
        /// </tr>
        /// <tr>
        /// <td>QTTYDM</td>
        /// <td>Other - Unified Social Credit Code</td>
        /// </tr>
        /// <tr>
        /// <td>SFJD</td>
        /// <td>Judicial appraisal license</td>
        /// </tr>
        /// <tr>
        /// <td>SHTTFR</td>
        /// <td>Social organization legal person registration certificate</td>
        /// </tr>
        /// <tr>
        /// <td>SHFWJG</td>
        /// <td>Social service institution registration certificate</td>
        /// </tr>
        /// <tr>
        /// <td>SYDWFR</td>
        /// <td>Public institution legal person certificate</td>
        /// </tr>
        /// <tr>
        /// <td>TYDM</td>
        /// <td>Unified Social Credit Code certificate</td>
        /// </tr>
        /// <tr>
        /// <td>YLJGZY</td>
        /// <td>Medical institution practice license</td>
        /// </tr>
        /// <tr>
        /// <td>ZCWYHDJZ</td>
        /// <td>Arbitration commission registration certificate</td>
        /// </tr>
        /// <tr>
        /// <td>ZJCS</td>
        /// <td>Religious activity venue registration certificate</td>
        /// </tr>
        /// <tr>
        /// <td>BJWSXX</td>
        /// <td>Beijing operating license for schools for children of foreign embassy staff</td>
        /// </tr>
        /// <tr>
        /// <td>JWJG</td>
        /// <td>Overseas institution certificate</td>
        /// </tr>
        /// <tr>
        /// <td>JWFZFDBJ</td>
        /// <td>Overseas non-governmental organization representative office registration certificate</td>
        /// </tr>
        /// <tr>
        /// <td>WGCZJG</td>
        /// <td>Foreign enterprise permanent representative office registration certificate</td>
        /// </tr>
        /// <tr>
        /// <td>WGZHWH</td>
        /// <td>Foreign cultural center registration certificate in China</td>
        /// </tr>
        /// <tr>
        /// <td>WGZHXWJG</td>
        /// <td>Foreign news agency certificate in China</td>
        /// </tr>
        /// <tr>
        /// <td>WJLSFZ</td>
        /// <td>Foreigner permanent residence ID card</td>
        /// </tr>
        /// <tr>
        /// <td>WLCZJG</td>
        /// <td>Approval registration certificate for permanent representative offices of foreign government tourism departments</td>
        /// </tr>
        /// <tr>
        /// <td>QT</td>
        /// <td>Other</td>
        /// </tr>
        /// </tbody></table>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SFZ</para>
        /// </summary>
        [NameInMap("DocumentType")]
        [Validation(Required=false)]
        public string DocumentType { get; set; }

        /// <summary>
        /// <para>The email address. The value cannot exceed 300 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:example@example.com">example@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The name of the registrant. The value cannot exceed 255 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张xx</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The phone number of the registrant. The value cannot exceed 128 characters in length. If the country is China and the number is not a mobile phone number, the area code must match the city.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13112345678</para>
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <para>The province of the registrant. The value cannot exceed 255 characters in length. If the country is China, the value must comply with GB/T 2260-2007.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>浙江省</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The address of the registrant. The value cannot exceed 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx区xx街道</para>
        /// </summary>
        [NameInMap("Street")]
        [Validation(Required=false)]
        public string Street { get; set; }

    }

}
