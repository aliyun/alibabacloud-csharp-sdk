// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetServiceFuncStatusRequest : TeaModel {
        /// <summary>
        /// <para>channel name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>Diagnosis parameters. Different types of diagnosis require different diagnosis parameters. You can use this field to filter records whose parameter values match the specified values.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public GetServiceFuncStatusRequestParams Params { get; set; }
        public class GetServiceFuncStatusRequestParams : TeaModel {
            /// <summary>
            /// <para>feature name</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mullprof</para>
            /// </summary>
            [NameInMap("function_name")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// <para>instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2zei55fwj8nnu31h3z46</para>
            /// </summary>
            [NameInMap("instance")]
            [Validation(Required=false)]
            public string Instance { get; set; }

            /// <summary>
            /// <para>User ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1338904783509062</para>
            /// </summary>
            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// <para>Service Name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>livetrace</para>
        /// </summary>
        [NameInMap("service_name")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
