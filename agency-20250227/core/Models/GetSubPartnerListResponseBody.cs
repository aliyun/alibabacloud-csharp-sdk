// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class GetSubPartnerListResponseBody : TeaModel {
        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// <para>The number of secondary distributors returned per page. Maximum value: 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of secondary distributors.</para>
        /// </summary>
        [NameInMap("SubPartnerList")]
        [Validation(Required=false)]
        public List<GetSubPartnerListResponseBodySubPartnerList> SubPartnerList { get; set; }
        public class GetSubPartnerListResponseBodySubPartnerList : TeaModel {
            /// <summary>
            /// <para>The detailed registered address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx街道xxx号</para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>The agreement status code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE_PERIOD</para>
            /// </summary>
            [NameInMap("AgreementStatus")]
            [Validation(Required=false)]
            public string AgreementStatus { get; set; }

            /// <summary>
            /// <para>The description of the agreement status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>生效期</para>
            /// </summary>
            [NameInMap("AgreementStatusDesc")]
            [Validation(Required=false)]
            public string AgreementStatusDesc { get; set; }

            /// <summary>
            /// <para>The city of the registered address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>杭州市</para>
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <para>The name of the secondary distributor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx有限公司</para>
            /// </summary>
            [NameInMap("CompanyName")]
            [Validation(Required=false)]
            public string CompanyName { get; set; }

            /// <summary>
            /// <para>The name of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("Contact")]
            [Validation(Required=false)]
            public string Contact { get; set; }

            /// <summary>
            /// <para>The district or county of the registered address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>西湖区</para>
            /// </summary>
            [NameInMap("District")]
            [Validation(Required=false)]
            public string District { get; set; }

            /// <summary>
            /// <para>The time when the secondary distributor first joined.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000-01-01</para>
            /// </summary>
            [NameInMap("JoinTime")]
            [Validation(Required=false)]
            public string JoinTime { get; set; }

            /// <summary>
            /// <para>The name of the primary account of the secondary distributor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxx有限公司主账号</para>
            /// </summary>
            [NameInMap("MasterAccount")]
            [Validation(Required=false)]
            public string MasterAccount { get; set; }

            /// <summary>
            /// <para>The UID of the primary account of the secondary distributor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("MasterUid")]
            [Validation(Required=false)]
            public string MasterUid { get; set; }

            /// <summary>
            /// <para>The PID of the secondary distributor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>P123456</para>
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// <para>The province of the registered address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>浙江省</para>
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
