// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class TicketQueryShelfResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TicketQueryShelfResponseBodyData Data { get; set; }
        public class TicketQueryShelfResponseBodyData : TeaModel {
            [NameInMap("Shelves")]
            [Validation(Required=false)]
            public List<TicketQueryShelfResponseBodyDataShelves> Shelves { get; set; }
            public class TicketQueryShelfResponseBodyDataShelves : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1951890</para>
                /// </summary>
                [NameInMap("ShelfId")]
                [Validation(Required=false)]
                public long? ShelfId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ShelfIndex")]
                [Validation(Required=false)]
                public int? ShelfIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1日门票</para>
                /// </summary>
                [NameInMap("ShelfName")]
                [Validation(Required=false)]
                public string ShelfName { get; set; }

                [NameInMap("Tabs")]
                [Validation(Required=false)]
                public List<TicketQueryShelfResponseBodyDataShelvesTabs> Tabs { get; set; }
                public class TicketQueryShelfResponseBodyDataShelvesTabs : TeaModel {
                    [NameInMap("Cells")]
                    [Validation(Required=false)]
                    public List<TicketQueryShelfResponseBodyDataShelvesTabsCells> Cells { get; set; }
                    public class TicketQueryShelfResponseBodyDataShelvesTabsCells : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3507</para>
                        /// </summary>
                        [NameInMap("SpuId")]
                        [Validation(Required=false)]
                        public long? SpuId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>60484007</para>
                        /// </summary>
                        [NameInMap("TicketKindId")]
                        [Validation(Required=false)]
                        public long? TicketKindId { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TabIndex")]
                    [Validation(Required=false)]
                    public int? TabIndex { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>景点门票</para>
                    /// </summary>
                    [NameInMap("TabName")]
                    [Validation(Required=false)]
                    public string TabName { get; set; }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ScenicIdInvalid</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ScenicId不合法</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
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
