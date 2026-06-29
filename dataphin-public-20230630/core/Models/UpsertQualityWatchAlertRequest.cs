// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpsertQualityWatchAlertRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The update instruction.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpsertCommand")]
        [Validation(Required=false)]
        public UpsertQualityWatchAlertRequestUpsertCommand UpsertCommand { get; set; }
        public class UpsertQualityWatchAlertRequestUpsertCommand : TeaModel {
            /// <summary>
            /// <para>The alert configuration details.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("QualityAlertInfo")]
            [Validation(Required=false)]
            public UpsertQualityWatchAlertRequestUpsertCommandQualityAlertInfo QualityAlertInfo { get; set; }
            public class UpsertQualityWatchAlertRequestUpsertCommandQualityAlertInfo : TeaModel {
                /// <summary>
                /// <para>The alert channels for on-duty schedules.</para>
                /// </summary>
                [NameInMap("AlertDutyChannelList")]
                [Validation(Required=false)]
                public List<string> AlertDutyChannelList { get; set; }

                /// <summary>
                /// <para>The list of on-duty schedules for alerts.</para>
                /// </summary>
                [NameInMap("AlertDutyList")]
                [Validation(Required=false)]
                public List<UpsertQualityWatchAlertRequestUpsertCommandQualityAlertInfoAlertDutyList> AlertDutyList { get; set; }
                public class UpsertQualityWatchAlertRequestUpsertCommandQualityAlertInfoAlertDutyList : TeaModel {
                    /// <summary>
                    /// <para>The ID of the on-duty alert schedule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The name of the on-duty alert schedule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The alert channels for the quality owner.</para>
                /// </summary>
                [NameInMap("AlertQualityOwnerChannelList")]
                [Validation(Required=false)]
                public List<string> AlertQualityOwnerChannelList { get; set; }

                /// <summary>
                /// <para>The alert channels for users.</para>
                /// </summary>
                [NameInMap("AlertUserChannelList")]
                [Validation(Required=false)]
                public List<string> AlertUserChannelList { get; set; }

                /// <summary>
                /// <para>The list of users to receive alerts.</para>
                /// </summary>
                [NameInMap("AlertUserList")]
                [Validation(Required=false)]
                public List<UpsertQualityWatchAlertRequestUpsertCommandQualityAlertInfoAlertUserList> AlertUserList { get; set; }
                public class UpsertQualityWatchAlertRequestUpsertCommandQualityAlertInfoAlertUserList : TeaModel {
                    /// <summary>
                    /// <para>The user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30012011</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The username.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>Specifies whether to enable alerts for the quality owner.</para>
                /// </summary>
                [NameInMap("EnableAlertQualityOwner")]
                [Validation(Required=false)]
                public bool? EnableAlertQualityOwner { get; set; }

            }

            /// <summary>
            /// <para>The ID of the monitored object.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("WatchId")]
            [Validation(Required=false)]
            public long? WatchId { get; set; }

        }

    }

}
