// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Companyreg20260423.Models
{
    public class QuerySuccessIcpDataResponseBody : TeaModel {
        [NameInMap("BaSuccessDataWithRiskList")]
        [Validation(Required=false)]
        public List<QuerySuccessIcpDataResponseBodyBaSuccessDataWithRiskList> BaSuccessDataWithRiskList { get; set; }
        public class QuerySuccessIcpDataResponseBodyBaSuccessDataWithRiskList : TeaModel {
            [NameInMap("AppList")]
            [Validation(Required=false)]
            public List<QuerySuccessIcpDataResponseBodyBaSuccessDataWithRiskListAppList> AppList { get; set; }
            public class QuerySuccessIcpDataResponseBodyBaSuccessDataWithRiskListAppList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>alipay</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("AppRecordNum")]
                [Validation(Required=false)]
                public string AppRecordNum { get; set; }

                [NameInMap("DomainList")]
                [Validation(Required=false)]
                public List<string> DomainList { get; set; }

                [NameInMap("ResponsiblePersonName")]
                [Validation(Required=false)]
                public string ResponsiblePersonName { get; set; }

            }

            [NameInMap("IcpNumber")]
            [Validation(Required=false)]
            public string IcpNumber { get; set; }

            [NameInMap("OrganizersName")]
            [Validation(Required=false)]
            public string OrganizersName { get; set; }

            [NameInMap("OrganizersNature")]
            [Validation(Required=false)]
            public string OrganizersNature { get; set; }

            [NameInMap("ResponsiblePersonName")]
            [Validation(Required=false)]
            public string ResponsiblePersonName { get; set; }

            [NameInMap("RiskList")]
            [Validation(Required=false)]
            public List<QuerySuccessIcpDataResponseBodyBaSuccessDataWithRiskListRiskList> RiskList { get; set; }
            public class QuerySuccessIcpDataResponseBodyBaSuccessDataWithRiskListRiskList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-04-24</para>
                /// </summary>
                [NameInMap("DeadLine")]
                [Validation(Required=false)]
                public string DeadLine { get; set; }

                [NameInMap("RiskDetailList")]
                [Validation(Required=false)]
                public List<QuerySuccessIcpDataResponseBodyBaSuccessDataWithRiskListRiskListRiskDetailList> RiskDetailList { get; set; }
                public class QuerySuccessIcpDataResponseBodyBaSuccessDataWithRiskListRiskListRiskDetailList : TeaModel {
                    [NameInMap("RectifySuggestList")]
                    [Validation(Required=false)]
                    public List<string> RectifySuggestList { get; set; }

                    [NameInMap("RiskSource")]
                    [Validation(Required=false)]
                    public string RiskSource { get; set; }

                }

            }

            [NameInMap("WebsiteList")]
            [Validation(Required=false)]
            public List<QuerySuccessIcpDataResponseBodyBaSuccessDataWithRiskListWebsiteList> WebsiteList { get; set; }
            public class QuerySuccessIcpDataResponseBodyBaSuccessDataWithRiskListWebsiteList : TeaModel {
                [NameInMap("DomainList")]
                [Validation(Required=false)]
                public List<string> DomainList { get; set; }

                [NameInMap("ResponsiblePersonName")]
                [Validation(Required=false)]
                public string ResponsiblePersonName { get; set; }

                [NameInMap("SiteName")]
                [Validation(Required=false)]
                public string SiteName { get; set; }

                [NameInMap("SiteRecordNum")]
                [Validation(Required=false)]
                public string SiteRecordNum { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NoPermission</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A13ABB5-7649-5031-B55C-D2E38F9F189D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
