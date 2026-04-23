// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryRegistrantProfilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        /// <summary>
        /// <para>Indicates whether the current page is followed by a page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page. Default value: <b>0</b>. Maximum value: <b>5000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Indicates whether the current page is preceded by a page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        [NameInMap("RegistrantProfiles")]
        [Validation(Required=false)]
        public QueryRegistrantProfilesResponseBodyRegistrantProfiles RegistrantProfiles { get; set; }
        public class QueryRegistrantProfilesResponseBodyRegistrantProfiles : TeaModel {
            [NameInMap("RegistrantProfile")]
            [Validation(Required=false)]
            public List<QueryRegistrantProfilesResponseBodyRegistrantProfilesRegistrantProfile> RegistrantProfile { get; set; }
            public class QueryRegistrantProfilesResponseBodyRegistrantProfilesRegistrantProfile : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("City")]
                [Validation(Required=false)]
                public string City { get; set; }

                [NameInMap("Country")]
                [Validation(Required=false)]
                public string Country { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CredentialNo")]
                [Validation(Required=false)]
                public string CredentialNo { get; set; }

                [NameInMap("CredentialType")]
                [Validation(Required=false)]
                public string CredentialType { get; set; }

                [NameInMap("DefaultRegistrantProfile")]
                [Validation(Required=false)]
                public bool? DefaultRegistrantProfile { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("EmailVerificationStatus")]
                [Validation(Required=false)]
                public int? EmailVerificationStatus { get; set; }

                [NameInMap("Params")]
                [Validation(Required=false)]
                public string Params { get; set; }

                [NameInMap("PostalCode")]
                [Validation(Required=false)]
                public string PostalCode { get; set; }

                [NameInMap("Province")]
                [Validation(Required=false)]
                public string Province { get; set; }

                [NameInMap("RealNameStatus")]
                [Validation(Required=false)]
                public string RealNameStatus { get; set; }

                [NameInMap("RegistrantName")]
                [Validation(Required=false)]
                public string RegistrantName { get; set; }

                [NameInMap("RegistrantOrganization")]
                [Validation(Required=false)]
                public string RegistrantOrganization { get; set; }

                [NameInMap("RegistrantProfileId")]
                [Validation(Required=false)]
                public long? RegistrantProfileId { get; set; }

                [NameInMap("RegistrantProfileType")]
                [Validation(Required=false)]
                public string RegistrantProfileType { get; set; }

                [NameInMap("RegistrantType")]
                [Validation(Required=false)]
                public string RegistrantType { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("TelArea")]
                [Validation(Required=false)]
                public string TelArea { get; set; }

                [NameInMap("TelExt")]
                [Validation(Required=false)]
                public string TelExt { get; set; }

                [NameInMap("Telephone")]
                [Validation(Required=false)]
                public string Telephone { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("ZhAddress")]
                [Validation(Required=false)]
                public string ZhAddress { get; set; }

                [NameInMap("ZhCity")]
                [Validation(Required=false)]
                public string ZhCity { get; set; }

                [NameInMap("ZhProvince")]
                [Validation(Required=false)]
                public string ZhProvince { get; set; }

                [NameInMap("ZhRegistrantName")]
                [Validation(Required=false)]
                public string ZhRegistrantName { get; set; }

                [NameInMap("ZhRegistrantOrganization")]
                [Validation(Required=false)]
                public string ZhRegistrantOrganization { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94053D79-7455-4F71-BF06-20EB2DEDE6BD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// <remarks>
        /// <para> This parameter indicates the total number of queried registrant profiles. If multiple registrant profiles are queried, the information about these profiles is returned in sequence by profile.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        /// <summary>
        /// <para>The total number of returned pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
