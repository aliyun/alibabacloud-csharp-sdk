// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCompaniesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of companies.</para>
        /// </summary>
        [NameInMap("CompanyList")]
        [Validation(Required=false)]
        public List<ListCompaniesResponseBodyCompanyList> CompanyList { get; set; }
        public class ListCompaniesResponseBodyCompanyList : TeaModel {
            /// <summary>
            /// <para>The city.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Beijing</para>
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <para>The company address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("CompanyAddress")]
            [Validation(Required=false)]
            public string CompanyAddress { get; set; }

            /// <summary>
            /// <para>The company code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("CompanyCode")]
            [Validation(Required=false)]
            public string CompanyCode { get; set; }

            /// <summary>
            /// <para>The company email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@163.com">test@163.com</a></para>
            /// </summary>
            [NameInMap("CompanyEmail")]
            [Validation(Required=false)]
            public string CompanyEmail { get; set; }

            /// <summary>
            /// <para>The company ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>51001</para>
            /// </summary>
            [NameInMap("CompanyId")]
            [Validation(Required=false)]
            public long? CompanyId { get; set; }

            /// <summary>
            /// <para>The name of the company or organization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testYanwen045</para>
            /// </summary>
            [NameInMap("CompanyName")]
            [Validation(Required=false)]
            public string CompanyName { get; set; }

            /// <summary>
            /// <para>The company phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1511</para>
            /// </summary>
            [NameInMap("CompanyPhone")]
            [Validation(Required=false)]
            public string CompanyPhone { get; set; }

            /// <summary>
            /// <para>The company code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("CompanyType")]
            [Validation(Required=false)]
            public int? CompanyType { get; set; }

            /// <summary>
            /// <para>The country code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("CountryCode")]
            [Validation(Required=false)]
            public string CountryCode { get; set; }

            /// <summary>
            /// <para>The department.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            /// <summary>
            /// <para>The language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// <para>The postal code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("PostCode")]
            [Validation(Required=false)]
            public string PostCode { get; set; }

            /// <summary>
            /// <para>The province.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

        }

        /// <summary>
        /// <para>Settings the page number of the current page in a paged query for paging. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>285BBE08-F12B-5A04-97BC-09EA7FF18646</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of certificates to display per page in a paged query. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The total number of search results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
