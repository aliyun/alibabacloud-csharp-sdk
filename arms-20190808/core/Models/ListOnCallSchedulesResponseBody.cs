// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListOnCallSchedulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The objects that were returned.</para>
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public ListOnCallSchedulesResponseBodyPageBean PageBean { get; set; }
        public class ListOnCallSchedulesResponseBodyPageBean : TeaModel {
            /// <summary>
            /// <para>The information about the scheduling policy.</para>
            /// </summary>
            [NameInMap("OnCallSchedules")]
            [Validation(Required=false)]
            public List<ListOnCallSchedulesResponseBodyPageBeanOnCallSchedules> OnCallSchedules { get; set; }
            public class ListOnCallSchedulesResponseBodyPageBeanOnCallSchedules : TeaModel {
                /// <summary>
                /// <para>The description of the scheduling policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test scheduling policy</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the scheduling policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the scheduling policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OnCallSchedule_test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78901766-3806-4E96-8E47-CFEF59E4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
