// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeBatchSlsDispatchStatusResponseBody : TeaModel {
        [NameInMap("ItemList")]
        [Validation(Required=false)]
        public List<DescribeBatchSlsDispatchStatusResponseBodyItemList> ItemList { get; set; }
        public class DescribeBatchSlsDispatchStatusResponseBodyItemList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>success_finished</para>
            /// </summary>
            [NameInMap("ConfigStatus")]
            [Validation(Required=false)]
            public string ConfigStatus { get; set; }

            [NameInMap("DispatchName")]
            [Validation(Required=false)]
            public string DispatchName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>internet_log</para>
            /// </summary>
            [NameInMap("DispatchValue")]
            [Validation(Required=false)]
            public string DispatchValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("FilterKeys")]
            [Validation(Required=false)]
            public List<string> FilterKeys { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>log_type</para>
            /// </summary>
            [NameInMap("SearchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rs-stats</para>
        /// </summary>
        [NameInMap("LogstoreName")]
        [Validation(Required=false)]
        public string LogstoreName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cloudfirewallnew-project-199053910542****-cn-hangzhou</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7036EBAB-F85F-5AAE-976F-C75AEE59****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
