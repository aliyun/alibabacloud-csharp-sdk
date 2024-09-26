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
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of data synchronization instances displayed on one page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1413460B-138A-48D1-836C-B24EDDC1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The status of the data synchronization tasks.</para>
        /// </summary>
        [NameInMap("SynchronizationJobListStatusList")]
        [Validation(Required=false)]
        public List<DescribeSynchronizationJobStatusListResponseBodySynchronizationJobListStatusList> SynchronizationJobListStatusList { get; set; }
        public class DescribeSynchronizationJobStatusListResponseBodySynchronizationJobListStatusList : TeaModel {
            /// <summary>
            /// <para>The details of data synchronization tasks in each direction.</para>
            /// </summary>
            [NameInMap("SynchronizationDirectionInfoList")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationJobStatusListResponseBodySynchronizationJobListStatusListSynchronizationDirectionInfoList> SynchronizationDirectionInfoList { get; set; }
            public class DescribeSynchronizationJobStatusListResponseBodySynchronizationJobListStatusListSynchronizationDirectionInfoList : TeaModel {
                /// <summary>
                /// <para>The UNIX timestamp generated when the latest data record was synchronized.</para>
                /// <remarks>
                /// <para> You can use a search engine to obtain a UNIX timestamp converter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1610524452</para>
                /// </summary>
                [NameInMap("Checkpoint")]
                [Validation(Required=false)]
                public string Checkpoint { get; set; }

                /// <summary>
                /// <para>The status of the data synchronization task in this direction. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NotStarted</b>: The task is not started.</description></item>
                /// <item><description><b>Prechecking</b>: The task is being prechecked.</description></item>
                /// <item><description><b>PrecheckFailed</b>: The task failed to pass the precheck.</description></item>
                /// <item><description><b>Initializing</b>: The task is performing initial synchronization.</description></item>
                /// <item><description><b>InitializeFailed</b>: Initial synchronization failed.</description></item>
                /// <item><description><b>Synchronizing</b>: The task is synchronizing data.</description></item>
                /// <item><description><b>Failed</b>: The task failed to synchronize data.</description></item>
                /// <item><description><b>Suspending</b>: The task is paused.</description></item>
                /// <item><description><b>Modifying</b>: The objects in the task are being modified.</description></item>
                /// <item><description><b>Finished</b>: The task is completed.</description></item>
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
                /// <item><description><b>Forward</b></description></item>
                /// <item><description><b>Reverse</b></description></item>
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
            /// <para>The ID of the data synchronization instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtsexjk1alb116****</para>
            /// </summary>
            [NameInMap("SynchronizationJobId")]
            [Validation(Required=false)]
            public string SynchronizationJobId { get; set; }

        }

        /// <summary>
        /// <para>The total number of data synchronization instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
