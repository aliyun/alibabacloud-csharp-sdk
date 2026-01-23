// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpsertQualityWatchAlertRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpsertCommand")]
        [Validation(Required=false)]
        public UpsertQualityWatchAlertRequestUpsertCommand UpsertCommand { get; set; }
        public class UpsertQualityWatchAlertRequestUpsertCommand : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("QualityAlertInfo")]
            [Validation(Required=false)]
            public UpsertQualityWatchAlertRequestUpsertCommandQualityAlertInfo QualityAlertInfo { get; set; }
            public class UpsertQualityWatchAlertRequestUpsertCommandQualityAlertInfo : TeaModel {
                [NameInMap("AlertDutyChannelList")]
                [Validation(Required=false)]
                public List<string> AlertDutyChannelList { get; set; }

                [NameInMap("AlertDutyList")]
                [Validation(Required=false)]
                public List<UpsertQualityWatchAlertRequestUpsertCommandQualityAlertInfoAlertDutyList> AlertDutyList { get; set; }
                public class UpsertQualityWatchAlertRequestUpsertCommandQualityAlertInfoAlertDutyList : TeaModel {
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
                public List<UpsertQualityWatchAlertRequestUpsertCommandQualityAlertInfoAlertUserList> AlertUserList { get; set; }
                public class UpsertQualityWatchAlertRequestUpsertCommandQualityAlertInfoAlertUserList : TeaModel {
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

            }

            /// <summary>
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
