// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Marketing_event20210101.Models
{
    public class FindGuestCredentialsRecordResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<FindGuestCredentialsRecordResponseBodyData> Data { get; set; }
        public class FindGuestCredentialsRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Admin")]
            [Validation(Required=false)]
            public Dictionary<string, object> Admin { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1401</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public long? ChannelId { get; set; }

            [NameInMap("ChannelLevelInfo")]
            [Validation(Required=false)]
            public FindGuestCredentialsRecordResponseBodyDataChannelLevelInfo ChannelLevelInfo { get; set; }
            public class FindGuestCredentialsRecordResponseBodyDataChannelLevelInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1401</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public long? ChannelId { get; set; }

                [NameInMap("ChannelName")]
                [Validation(Required=false)]
                public string ChannelName { get; set; }

                [NameInMap("LevelOneChannelName")]
                [Validation(Required=false)]
                public string LevelOneChannelName { get; set; }

                [NameInMap("LevelOneOwner")]
                [Validation(Required=false)]
                public List<FindGuestCredentialsRecordResponseBodyDataChannelLevelInfoLevelOneOwner> LevelOneOwner { get; set; }
                public class FindGuestCredentialsRecordResponseBodyDataChannelLevelInfoLevelOneOwner : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>hBCycGELqJd6LEqSWKiLCQ==</para>
                    /// </summary>
                    [NameInMap("OwnerEmpIdOrTelephone")]
                    [Validation(Required=false)]
                    public string OwnerEmpIdOrTelephone { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>buc_396545</para>
                    /// </summary>
                    [NameInMap("OwnerName")]
                    [Validation(Required=false)]
                    public string OwnerName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>hBCycGELqJd6LEqSWKiLCQ==</para>
                    /// </summary>
                    [NameInMap("OwnerNickName")]
                    [Validation(Required=false)]
                    public string OwnerNickName { get; set; }

                }

                [NameInMap("LevelThreeChannelName")]
                [Validation(Required=false)]
                public string LevelThreeChannelName { get; set; }

                [NameInMap("LevelThreeOwner")]
                [Validation(Required=false)]
                public List<FindGuestCredentialsRecordResponseBodyDataChannelLevelInfoLevelThreeOwner> LevelThreeOwner { get; set; }
                public class FindGuestCredentialsRecordResponseBodyDataChannelLevelInfoLevelThreeOwner : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>hBCycGELqJd6LEqSWKiLCQ==</para>
                    /// </summary>
                    [NameInMap("OwnerEmpIdOrTelephone")]
                    [Validation(Required=false)]
                    public string OwnerEmpIdOrTelephone { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>buc_160953</para>
                    /// </summary>
                    [NameInMap("OwnerName")]
                    [Validation(Required=false)]
                    public string OwnerName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>hBCycGELqJd6LEqSWKiLCQ==</para>
                    /// </summary>
                    [NameInMap("OwnerNickName")]
                    [Validation(Required=false)]
                    public string OwnerNickName { get; set; }

                }

                [NameInMap("LevelTwoChannelName")]
                [Validation(Required=false)]
                public string LevelTwoChannelName { get; set; }

                [NameInMap("LevelTwoOwner")]
                [Validation(Required=false)]
                public List<FindGuestCredentialsRecordResponseBodyDataChannelLevelInfoLevelTwoOwner> LevelTwoOwner { get; set; }
                public class FindGuestCredentialsRecordResponseBodyDataChannelLevelInfoLevelTwoOwner : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>hBCycGELqJd6LEqSWKiLCQ==</para>
                    /// </summary>
                    [NameInMap("OwnerEmpIdOrTelephone")]
                    [Validation(Required=false)]
                    public string OwnerEmpIdOrTelephone { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>buc_87239</para>
                    /// </summary>
                    [NameInMap("OwnerName")]
                    [Validation(Required=false)]
                    public string OwnerName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>hBCycGELqJd6LEqSWKiLCQ==</para>
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
            /// <para>3602-10010215</para>
            /// </summary>
            [NameInMap("CredentialsCode")]
            [Validation(Required=false)]
            public string CredentialsCode { get; set; }

            [NameInMap("CredentialsName")]
            [Validation(Required=false)]
            public string CredentialsName { get; set; }

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

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
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
        /// <para>25294484-D133-5BDC-8952-243AD90CDF66</para>
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
