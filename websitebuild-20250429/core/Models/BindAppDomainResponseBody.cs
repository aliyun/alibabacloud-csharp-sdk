// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class BindAppDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason why access was denied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Indicates whether retry is allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>or</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message, which is used to replace the <b>%s</b> placeholder in the <b>ErrMessage</b> response parameter.</para>
        /// <remarks>
        /// <para>For example, if <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, the request parameter <b>DtsJobId</b> is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error parameters.</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>The data table module.</para>
        /// <list type="bullet">
        /// <item><description><para>ABTest: experiment data table</para>
        /// </description></item>
        /// <item><description><para>ExperimentTool: experiment tool table</para>
        /// </description></item>
        /// <item><description><para>DataDiagnosis: data diagnostics</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public BindAppDomainResponseBodyModule Module { get; set; }
        public class BindAppDomainResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The DNS conflict information. This parameter is returned when a conflict is detected during synchronous verification.</para>
            /// </summary>
            [NameInMap("DnsConflict")]
            [Validation(Required=false)]
            public BindAppDomainResponseBodyModuleDnsConflict DnsConflict { get; set; }
            public class BindAppDomainResponseBodyModuleDnsConflict : TeaModel {
                /// <summary>
                /// <para>Indicates whether automatic overwrite is supported. A value of true indicates the current Alibaba Cloud account, and a value of false indicates other accounts.</para>
                /// </summary>
                [NameInMap("CanAutoResolve")]
                [Validation(Required=false)]
                public bool? CanAutoResolve { get; set; }

                /// <summary>
                /// <para>Indicates whether a conflict exists.</para>
                /// </summary>
                [NameInMap("HasConflict")]
                [Validation(Required=false)]
                public bool? HasConflict { get; set; }

                /// <summary>
                /// <para>The user-facing prompt message. Different guidance text is generated based on the scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A conflicting DNS record (A 192.0.2.1) exists for the domain name <a href="http://www.example.com">www.example.com</a>. Delete the conflicting record from your DNS provider and try again</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The list of conflicting DNS records. This reuses the existing AppDomainDnsRecordDTO.</para>
                /// </summary>
                [NameInMap("Records")]
                [Validation(Required=false)]
                public List<BindAppDomainResponseBodyModuleDnsConflictRecords> Records { get; set; }
                public class BindAppDomainResponseBodyModuleDnsConflictRecords : TeaModel {
                    /// <summary>
                    /// <para>The host record.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>www</para>
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// <para>The record type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A</para>
                    /// </summary>
                    [NameInMap("RecordType")]
                    [Validation(Required=false)]
                    public string RecordType { get; set; }

                    /// <summary>
                    /// <para>The status of the conflicting DNS record. A value of ENABLE indicates that the record is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ENABLE</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The record value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.0.2.1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>Indicates whether the request was successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.EROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>The exception message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>System exception</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is processed synchronously.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
