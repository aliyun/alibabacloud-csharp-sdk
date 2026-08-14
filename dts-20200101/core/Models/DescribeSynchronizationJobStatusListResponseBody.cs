// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSynchronizationJobStatusListResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of synchronization instances displayed on one page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1413460B-138A-48D1-836C-B24EDDC1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The status list of synchronization jobs.</para>
        /// </summary>
        [NameInMap("SynchronizationJobListStatusList")]
        [Validation(Required=false)]
        public List<DescribeSynchronizationJobStatusListResponseBodySynchronizationJobListStatusList> SynchronizationJobListStatusList { get; set; }
        public class DescribeSynchronizationJobStatusListResponseBodySynchronizationJobListStatusList : TeaModel {
            /// <summary>
            /// <para>The list of synchronization direction details.</para>
            /// </summary>
            [NameInMap("SynchronizationDirectionInfoList")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationJobStatusListResponseBodySynchronizationJobListStatusListSynchronizationDirectionInfoList> SynchronizationDirectionInfoList { get; set; }
            public class DescribeSynchronizationJobStatusListResponseBodySynchronizationJobListStatusListSynchronizationDirectionInfoList : TeaModel {
                /// <summary>
                /// <para>The timestamp of the latest synchronized data, in UNIX timestamp format.</para>
                /// <remarks>
                /// <para>You can use a search engine to find a UNIX timestamp converter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1610524452</para>
                /// </summary>
                [NameInMap("Checkpoint")]
                [Validation(Required=false)]
                public string Checkpoint { get; set; }

                /// <summary>
                /// <para>The synchronization status of the synchronization instance in this direction. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NotStarted</b>: not started.</description></item>
                /// <item><description><b>Prechecking</b>: running a precheck.</description></item>
                /// <item><description><b>PrecheckFailed</b>: precheck failed.</description></item>
                /// <item><description><b>Initializing</b>: performing initial synchronization.</description></item>
                /// <item><description><b>InitializeFailed</b>: initial synchronization failed.</description></item>
                /// <item><description><b>Synchronizing</b>: synchronizing.</description></item>
                /// <item><description><b>Failed</b>: synchronization failed.</description></item>
                /// <item><description><b>Suspending</b>: paused.</description></item>
                /// <item><description><b>Modifying</b>: modifying synchronization objects.</description></item>
                /// <item><description><b>Finished</b>: completed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>InitializeFailed</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The synchronization direction. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Forward</b>: forward.</description></item>
                /// <item><description><b>Reverse</b>: reverse.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Forward</para>
                /// </summary>
                [NameInMap("SynchronizationDirection")]
                [Validation(Required=false)]
                public string SynchronizationDirection { get; set; }

            }

            /// <summary>
            /// <para>The instance ID of the data synchronization instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtsexjk1alb116****</para>
            /// </summary>
            [NameInMap("SynchronizationJobId")]
            [Validation(Required=false)]
            public string SynchronizationJobId { get; set; }

        }

        /// <summary>
        /// <para>The total number of synchronization instances that were queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
