// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetQualityAlertOfAllRuleScopeByWatchIdResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("QualityAlertInfo")]
        [Validation(Required=false)]
        public GetQualityAlertOfAllRuleScopeByWatchIdResponseBodyQualityAlertInfo QualityAlertInfo { get; set; }
        public class GetQualityAlertOfAllRuleScopeByWatchIdResponseBodyQualityAlertInfo : TeaModel {
            [NameInMap("AlertDutyChannelList")]
            [Validation(Required=false)]
            public List<string> AlertDutyChannelList { get; set; }

            [NameInMap("AlertDutyList")]
            [Validation(Required=false)]
            public List<GetQualityAlertOfAllRuleScopeByWatchIdResponseBodyQualityAlertInfoAlertDutyList> AlertDutyList { get; set; }
            public class GetQualityAlertOfAllRuleScopeByWatchIdResponseBodyQualityAlertInfoAlertDutyList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("AlertQualityOwnerChannelList")]
            [Validation(Required=false)]
            public List<string> AlertQualityOwnerChannelList { get; set; }

            [NameInMap("AlertUserChannelList")]
            [Validation(Required=false)]
            public List<string> AlertUserChannelList { get; set; }

            [NameInMap("AlertUserList")]
            [Validation(Required=false)]
            public List<GetQualityAlertOfAllRuleScopeByWatchIdResponseBodyQualityAlertInfoAlertUserList> AlertUserList { get; set; }
            public class GetQualityAlertOfAllRuleScopeByWatchIdResponseBodyQualityAlertInfoAlertUserList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("EnableAlertQualityOwner")]
            [Validation(Required=false)]
            public bool? EnableAlertQualityOwner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WatchId")]
            [Validation(Required=false)]
            public long? WatchId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
