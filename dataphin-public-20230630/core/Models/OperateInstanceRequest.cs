// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class OperateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The environment identifier. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DEV: development environment. </description></item>
        /// <item><description>PROD (default): production environment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The operation request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OperateCommand")]
        [Validation(Required=false)]
        public OperateInstanceRequestOperateCommand OperateCommand { get; set; }
        public class OperateInstanceRequestOperateCommand : TeaModel {
            /// <summary>
            /// <para>The list of instances to operate on.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("InstanceIdList")]
            [Validation(Required=false)]
            public List<OperateInstanceRequestOperateCommandInstanceIdList> InstanceIdList { get; set; }
            public class OperateInstanceRequestOperateCommandInstanceIdList : TeaModel {
                /// <summary>
                /// <para>The field instance IDs.</para>
                /// </summary>
                [NameInMap("FieldInstanceIdList")]
                [Validation(Required=false)]
                public List<string> FieldInstanceIdList { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t_32111312</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            /// <summary>
            /// <para>The operation to perform. Valid values:	</para>
            /// <list type="bullet">
            /// <item><description>RERUN: Reruns the instance.</description></item>
            /// <item><description>PAUSE: Pauses the instance.</description></item>
            /// <item><description>RESUME: Resumes the instance.</description></item>
            /// <item><description>TERMINATE: Stops the instance.</description></item>
            /// <item><description>SET_SUCCESS: Sets the instance status to successful.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RERUN</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>132311</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

    }

}
