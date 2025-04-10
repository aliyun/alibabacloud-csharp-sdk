// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class GetEnrolledAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12868156179*****</para>
        /// </summary>
        [NameInMap("AccountUid")]
        [Validation(Required=false)]
        public long? AccountUid { get; set; }

        /// <summary>
        /// <para>The ID of the baseline that is implemented.</para>
        /// 
        /// <b>Example:</b>
        /// <para>afb-bp1adadfadsf***</para>
        /// </summary>
        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public string BaselineId { get; set; }

        /// <summary>
        /// <para>The array that contains baseline items.</para>
        /// </summary>
        [NameInMap("BaselineItems")]
        [Validation(Required=false)]
        public List<GetEnrolledAccountResponseBodyBaselineItems> BaselineItems { get; set; }
        public class GetEnrolledAccountResponseBodyBaselineItems : TeaModel {
            /// <summary>
            /// <para>The configuration of the baseline item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Notifications\&quot;:[{\&quot;GroupKey\&quot;:\&quot;account_msg\&quot;,\&quot;Contacts\&quot;:[{\&quot;Name\&quot;:\&quot;aa\&quot;}],\&quot;PmsgStatus\&quot;:1,\&quot;EmailStatus\&quot;:1,\&quot;SmsStatus\&quot;:1}]}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The name of the baseline item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS-BP_ACCOUNT_FACTORY_VPC</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether baseline item is skipped. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false</description></item>
            /// <item><description>true</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Skip")]
            [Validation(Required=false)]
            public bool? Skip { get; set; }

            /// <summary>
            /// <para>The version of the baseline item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The time when the account was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-01T02:38:27Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The display name of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-account</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// <remarks>
        /// <para> This parameter is returned if the value of <c>Status</c> is <c>Failed</c> or <c>ScheduleFailed</c>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ErrorInfo")]
        [Validation(Required=false)]
        public GetEnrolledAccountResponseBodyErrorInfo ErrorInfo { get; set; }
        public class GetEnrolledAccountResponseBodyErrorInfo : TeaModel {
            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CompliancePackExists</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The compliance pack already exists.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The recommended solution.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://next.api.aliyun.com/troubleshoot?q=CompliancePackExists%5C%5C%5C%5Cu0026product=Config">https://next.api.aliyun.com/troubleshoot?q=CompliancePackExists\\\\u0026product=Config</a></para>
            /// </summary>
            [NameInMap("Recommend")]
            [Validation(Required=false)]
            public string Recommend { get; set; }

            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6D5EAA86-2D41-5CB7-8DA7-B60093ACAA4E</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the parent folder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fd-5ESoku****</para>
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <para>Indicates whether the initialization is complete. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false</description></item>
        /// <item><description>true</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Initialized")]
        [Validation(Required=false)]
        public bool? Initialized { get; set; }

        /// <summary>
        /// <para>Input parameters used to create an account.</para>
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public GetEnrolledAccountResponseBodyInputs Inputs { get; set; }
        public class GetEnrolledAccountResponseBodyInputs : TeaModel {
            /// <summary>
            /// <para>The prefix of the account name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-account</para>
            /// </summary>
            [NameInMap("AccountNamePrefix")]
            [Validation(Required=false)]
            public string AccountNamePrefix { get; set; }

            /// <summary>
            /// <para>The account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12868156179*****</para>
            /// </summary>
            [NameInMap("AccountUid")]
            [Validation(Required=false)]
            public long? AccountUid { get; set; }

            /// <summary>
            /// <para>The baseline items.</para>
            /// </summary>
            [NameInMap("BaselineItems")]
            [Validation(Required=false)]
            public List<GetEnrolledAccountResponseBodyInputsBaselineItems> BaselineItems { get; set; }
            public class GetEnrolledAccountResponseBodyInputsBaselineItems : TeaModel {
                /// <summary>
                /// <para>The configurations of the baseline item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;Contacts\&quot;:[{\&quot;Name\&quot;:\&quot;governance\&quot;,\&quot;Email\&quot;:\&quot;wibud****@gmail.com\&quot;,\&quot;Mobile\&quot;:\&quot;1234\&quot;,\&quot;Position\&quot;:\&quot;Other\&quot;}]}</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// <para>The name of the baseline item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS-BP_ACCOUNT_FACTORY_VPC</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Indicates whether baseline item is skipped. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>false</description></item>
                /// <item><description>true</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Skip")]
                [Validation(Required=false)]
                public bool? Skip { get; set; }

                /// <summary>
                /// <para>The version of the baseline item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The display name of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-account</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The ID of the parent folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd-5ESoku****</para>
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// <para>The ID of the settlement account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19534534552*****</para>
            /// </summary>
            [NameInMap("PayerAccountUid")]
            [Validation(Required=false)]
            public long? PayerAccountUid { get; set; }

            /// <summary>
            /// <para>The tag.</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<GetEnrolledAccountResponseBodyInputsTag> Tag { get; set; }
            public class GetEnrolledAccountResponseBodyInputsTag : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>product</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>governance</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the management account of the resource directory to which the account belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19534534552*****</para>
        /// </summary>
        [NameInMap("MasterAccountUid")]
        [Validation(Required=false)]
        public long? MasterAccountUid { get; set; }

        /// <summary>
        /// <para>The ID of the settlement account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19534534552*****</para>
        /// </summary>
        [NameInMap("PayerAccountUid")]
        [Validation(Required=false)]
        public long? PayerAccountUid { get; set; }

        /// <summary>
        /// <para>The progress of the applying the baseline to the account.</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public List<GetEnrolledAccountResponseBodyProgress> Progress { get; set; }
        public class GetEnrolledAccountResponseBodyProgress : TeaModel {
            /// <summary>
            /// <para>The name of the baseline item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS-BP_ACCOUNT_FACTORY_VPC</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of applying the baseline to the account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The baseline is pending to be applied to the account.</description></item>
            /// <item><description>Running: The baseline is being applied to the account.</description></item>
            /// <item><description>Finished: : The baseline is applied to the account.</description></item>
            /// <item><description>Failed: : The baseline fails to be applied to the account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>768F908D-A66A-5A5D-816C-20C93CBBFEE3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Pending: The account is pending to be created.</description></item>
        /// <item><description>Running: The account is being created.</description></item>
        /// <item><description>Finished: The account is created.</description></item>
        /// <item><description>Failed: The account fails to be created.</description></item>
        /// <item><description>Scheduling: The account is being scheduled.</description></item>
        /// <item><description>ScheduleFailed: The account fails to be scheduled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-01T02:38:27Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
