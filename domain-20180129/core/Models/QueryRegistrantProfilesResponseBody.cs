// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryRegistrantProfilesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>zhe jiang sheng hang zhou shi shi li qu shi li zhen shi li da sha 1001 hao</para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hang zhou shi</para>
                /// </summary>
                [NameInMap("City")]
                [Validation(Required=false)]
                public string City { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("Country")]
                [Validation(Required=false)]
                public string Country { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-02-18 10:46:47</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CredentialNo")]
                [Validation(Required=false)]
                public string CredentialNo { get; set; }

                [NameInMap("CredentialType")]
                [Validation(Required=false)]
                public string CredentialType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DefaultRegistrantProfile")]
                [Validation(Required=false)]
                public bool? DefaultRegistrantProfile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>82106****@qq.com</para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EmailVerificationStatus")]
                [Validation(Required=false)]
                public int? EmailVerificationStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>310024</para>
                /// </summary>
                [NameInMap("PostalCode")]
                [Validation(Required=false)]
                public string PostalCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>zhe jiang</para>
                /// </summary>
                [NameInMap("Province")]
                [Validation(Required=false)]
                public string Province { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SUCCEED</para>
                /// </summary>
                [NameInMap("RealNameStatus")]
                [Validation(Required=false)]
                public string RealNameStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>li si</para>
                /// </summary>
                [NameInMap("RegistrantName")]
                [Validation(Required=false)]
                public string RegistrantName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>li si</para>
                /// </summary>
                [NameInMap("RegistrantOrganization")]
                [Validation(Required=false)]
                public string RegistrantOrganization { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000001</para>
                /// </summary>
                [NameInMap("RegistrantProfileId")]
                [Validation(Required=false)]
                public long? RegistrantProfileId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>common</para>
                /// </summary>
                [NameInMap("RegistrantProfileType")]
                [Validation(Required=false)]
                public string RegistrantProfileType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RegistrantType")]
                [Validation(Required=false)]
                public string RegistrantType { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>86</para>
                /// </summary>
                [NameInMap("TelArea")]
                [Validation(Required=false)]
                public string TelArea { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("TelExt")]
                [Validation(Required=false)]
                public string TelExt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1829756****</para>
                /// </summary>
                [NameInMap("Telephone")]
                [Validation(Required=false)]
                public string Telephone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-03-15 15:32:45</para>
                /// </summary>
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
        /// <b>Example:</b>
        /// <para>94053D79-7455-4F71-BF06-20EB2DEDE6BD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
