// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Marketing_event20210101.Models
{
    public class FindGuestTicketRecordResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<FindGuestTicketRecordResponseBodyData> Data { get; set; }
        public class FindGuestTicketRecordResponseBodyData : TeaModel {
            [NameInMap("ChannelLevelInfo")]
            [Validation(Required=false)]
            public FindGuestTicketRecordResponseBodyDataChannelLevelInfo ChannelLevelInfo { get; set; }
            public class FindGuestTicketRecordResponseBodyDataChannelLevelInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1401</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public long? ChannelId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>VIP</para>
                /// </summary>
                [NameInMap("ChannelName")]
                [Validation(Required=false)]
                public string ChannelName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>VIP</para>
                /// </summary>
                [NameInMap("LevelOneChannelName")]
                [Validation(Required=false)]
                public string LevelOneChannelName { get; set; }

                [NameInMap("LevelOneOwner")]
                [Validation(Required=false)]
                public List<FindGuestTicketRecordResponseBodyDataChannelLevelInfoLevelOneOwner> LevelOneOwner { get; set; }
                public class FindGuestTicketRecordResponseBodyDataChannelLevelInfoLevelOneOwner : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>IjEqZpp8Wn29+sqOr3hxXuOqn6CyKYNSQ5dmMA0txiM=</para>
                    /// </summary>
                    [NameInMap("OwnerEmpIdOrTelephone")]
                    [Validation(Required=false)]
                    public string OwnerEmpIdOrTelephone { get; set; }

                    [NameInMap("OwnerName")]
                    [Validation(Required=false)]
                    public string OwnerName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dUffKUpLXP5LFGeJa+Rs8Q==</para>
                    /// </summary>
                    [NameInMap("OwnerNickName")]
                    [Validation(Required=false)]
                    public string OwnerNickName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>VIP</para>
                /// </summary>
                [NameInMap("LevelThreeChannelName")]
                [Validation(Required=false)]
                public string LevelThreeChannelName { get; set; }

                [NameInMap("LevelThreeOwner")]
                [Validation(Required=false)]
                public List<FindGuestTicketRecordResponseBodyDataChannelLevelInfoLevelThreeOwner> LevelThreeOwner { get; set; }
                public class FindGuestTicketRecordResponseBodyDataChannelLevelInfoLevelThreeOwner : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>IjEqZpp8Wn29+sqOr3hxXuOqn6CyKYNSQ5dmMA0txiM=</para>
                    /// </summary>
                    [NameInMap("OwnerEmpIdOrTelephone")]
                    [Validation(Required=false)]
                    public string OwnerEmpIdOrTelephone { get; set; }

                    [NameInMap("OwnerName")]
                    [Validation(Required=false)]
                    public string OwnerName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dUffKUpLXP5LFGeJa+Rs8Q==</para>
                    /// </summary>
                    [NameInMap("OwnerNickName")]
                    [Validation(Required=false)]
                    public string OwnerNickName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>VIP</para>
                /// </summary>
                [NameInMap("LevelTwoChannelName")]
                [Validation(Required=false)]
                public string LevelTwoChannelName { get; set; }

                [NameInMap("LevelTwoOwner")]
                [Validation(Required=false)]
                public List<FindGuestTicketRecordResponseBodyDataChannelLevelInfoLevelTwoOwner> LevelTwoOwner { get; set; }
                public class FindGuestTicketRecordResponseBodyDataChannelLevelInfoLevelTwoOwner : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>IjEqZpp8Wn29+sqOr3hxXuOqn6CyKYNSQ5dmMA0txiM=</para>
                    /// </summary>
                    [NameInMap("OwnerEmpIdOrTelephone")]
                    [Validation(Required=false)]
                    public string OwnerEmpIdOrTelephone { get; set; }

                    [NameInMap("OwnerName")]
                    [Validation(Required=false)]
                    public string OwnerName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dUffKUpLXP5LFGeJa+Rs8Q==</para>
                    /// </summary>
                    [NameInMap("OwnerNickName")]
                    [Validation(Required=false)]
                    public string OwnerNickName { get; set; }

                }

            }

            [NameInMap("CompanyName")]
            [Validation(Required=false)]
            public string CompanyName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-10-31,2023-11-02</para>
            /// </summary>
            [NameInMap("EquityDates")]
            [Validation(Required=false)]
            public string EquityDates { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("HealthCommitmentStatus")]
            [Validation(Required=false)]
            public int? HealthCommitmentStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>IjEqZpp8Wn29+sqOr3hxXuOqn6CyKYNSQ5dmMA0txiM=</para>
            /// </summary>
            [NameInMap("IdNumber")]
            [Validation(Required=false)]
            public string IdNumber { get; set; }

            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3702-10240842</para>
            /// </summary>
            [NameInMap("TicketCode")]
            [Validation(Required=false)]
            public string TicketCode { get; set; }

            [NameInMap("TicketName")]
            [Validation(Required=false)]
            public string TicketName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TicketType")]
            [Validation(Required=false)]
            public string TicketType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>error</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8D190CE8-7D76-5781-8055-0990BBD2249F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
