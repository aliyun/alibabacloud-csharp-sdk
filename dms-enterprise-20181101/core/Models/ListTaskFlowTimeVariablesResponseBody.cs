// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowTimeVariablesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC12A3BE-149F-5365-AF33-12CC8C963923</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The time variables for the task flow.</para>
        /// </summary>
        [NameInMap("TimeVariables")]
        [Validation(Required=false)]
        public ListTaskFlowTimeVariablesResponseBodyTimeVariables TimeVariables { get; set; }
        public class ListTaskFlowTimeVariablesResponseBodyTimeVariables : TeaModel {
            [NameInMap("TimeVariable")]
            [Validation(Required=false)]
            public List<ListTaskFlowTimeVariablesResponseBodyTimeVariablesTimeVariable> TimeVariable { get; set; }
            public class ListTaskFlowTimeVariablesResponseBodyTimeVariablesTimeVariable : TeaModel {
                /// <summary>
                /// <para>The name of the time variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>time_test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The format of the time variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-09-26|+7h</para>
                /// </summary>
                [NameInMap("Pattern")]
                [Validation(Required=false)]
                public string Pattern { get; set; }

            }

        }

    }

}
