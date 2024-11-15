// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class SubmitIsvCustomerTermsRequest : TeaModel {
        /// <summary>
        /// <para>The business scenario.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Marketing products</para>
        /// </summary>
        [NameInMap("BusinessDesc")]
        [Validation(Required=false)]
        public string BusinessDesc { get; set; }

        /// <summary>
        /// <para>The enterprise mail.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:partner@aliyun.com">partner@aliyun.com</a></para>
        /// </summary>
        [NameInMap("ContactMail")]
        [Validation(Required=false)]
        public string ContactMail { get; set; }

        /// <summary>
        /// <para>The country code.</para>
        /// <remarks>
        /// <para> For more information about country codes, see <a href="https://help.aliyun.com/document_detail/608210.html">Country codes</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("CountryId")]
        [Validation(Required=false)]
        public string CountryId { get; set; }

        /// <summary>
        /// <para>The enterprise name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun</para>
        /// </summary>
        [NameInMap("CustName")]
        [Validation(Required=false)]
        public string CustName { get; set; }

        /// <summary>
        /// <para>The space ID of the user within the independent software vendor (ISV) account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>293483938849493</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The ISV or Client agreement.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>isvTerms.pdf</para>
        /// </summary>
        [NameInMap("IsvTerms")]
        [Validation(Required=false)]
        public string IsvTerms { get; set; }

        /// <summary>
        /// <para>The enterprise address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hangzhou</para>
        /// </summary>
        [NameInMap("OfficeAddress")]
        [Validation(Required=false)]
        public string OfficeAddress { get; set; }

    }

}
