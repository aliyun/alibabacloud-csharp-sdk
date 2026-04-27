// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAutoProvisioningGroupHistoryResponseBody : TeaModel {
        [NameInMap("AutoProvisioningGroupHistories")]
        [Validation(Required=false)]
        public DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistories AutoProvisioningGroupHistories { get; set; }
        public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistories : TeaModel {
            [NameInMap("AutoProvisioningGroupHistory")]
            [Validation(Required=false)]
            public List<DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistory> AutoProvisioningGroupHistory { get; set; }
            public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistory : TeaModel {
                [NameInMap("ActivityDetails")]
                [Validation(Required=false)]
                public DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetails ActivityDetails { get; set; }
                public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetails : TeaModel {
                    [NameInMap("ActivityDetail")]
                    [Validation(Required=false)]
                    public List<DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetailsActivityDetail> ActivityDetail { get; set; }
                    public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetailsActivityDetail : TeaModel {
                        [NameInMap("CreatedInstanceIds")]
                        [Validation(Required=false)]
                        public DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetailsActivityDetailCreatedInstanceIds CreatedInstanceIds { get; set; }
                        public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetailsActivityDetailCreatedInstanceIds : TeaModel {
                            [NameInMap("CreatedInstanceId")]
                            [Validation(Required=false)]
                            public List<string> CreatedInstanceId { get; set; }

                        }

                        [NameInMap("DestroyedInstanceIds")]
                        [Validation(Required=false)]
                        public DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetailsActivityDetailDestroyedInstanceIds DestroyedInstanceIds { get; set; }
                        public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetailsActivityDetailDestroyedInstanceIds : TeaModel {
                            [NameInMap("DestroyedInstanceId")]
                            [Validation(Required=false)]
                            public List<string> DestroyedInstanceId { get; set; }

                        }

                        [NameInMap("Detail")]
                        [Validation(Required=false)]
                        public string Detail { get; set; }

                        [NameInMap("ErrorMessages")]
                        [Validation(Required=false)]
                        public DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetailsActivityDetailErrorMessages ErrorMessages { get; set; }
                        public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetailsActivityDetailErrorMessages : TeaModel {
                            [NameInMap("ErrorMessage")]
                            [Validation(Required=false)]
                            public List<DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetailsActivityDetailErrorMessagesErrorMessage> ErrorMessage { get; set; }
                            public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetailsActivityDetailErrorMessagesErrorMessage : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>InvalidSecurityGroupId.NotFound</para>
                                /// </summary>
                                [NameInMap("Code")]
                                [Validation(Required=false)]
                                public string Code { get; set; }

                                [NameInMap("FailedInstanceIds")]
                                [Validation(Required=false)]
                                public DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetailsActivityDetailErrorMessagesErrorMessageFailedInstanceIds FailedInstanceIds { get; set; }
                                public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetailsActivityDetailErrorMessagesErrorMessageFailedInstanceIds : TeaModel {
                                    [NameInMap("FailedInstanceId")]
                                    [Validation(Required=false)]
                                    public List<string> FailedInstanceId { get; set; }

                                }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>The specified SecurityGroupId &quot;sg-bp1d8modxxxxx&quot; is not found.</para>
                                /// </summary>
                                [NameInMap("Message")]
                                [Validation(Required=false)]
                                public string Message { get; set; }

                            }

                        }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                [NameInMap("LastEventTime")]
                [Validation(Required=false)]
                public string LastEventTime { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

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
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B48A12CD-1295-4A38-A8F0-0E92C937****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of queried scheduling tasks in the auto provisioning group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
