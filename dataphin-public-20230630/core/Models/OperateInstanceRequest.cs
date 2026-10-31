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
        /// <item><description>DEV: Development environment. </description></item>
        /// <item><description>PROD: Production environment. This is the default value.</description></item>
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
        /// <para>The operator user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The operation request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OperateCommand")]
        [Validation(Required=false)]
        public OperateInstanceRequestOperateCommand OperateCommand { get; set; }
        public class OperateInstanceRequestOperateCommand : TeaModel {
            /// <summary>
            /// <para>The O&amp;M instance list.</para>
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
            /// <para>The operation. Valid values:	</para>
            /// <list type="bullet">
            /// <item><description>RERUN: Rerun.</description></item>
            /// <item><description>PAUSE: Pause.</description></item>
            /// <item><description>RESUME: Resume.</description></item>
            /// <item><description>TERMINATE: Stop.</description></item>
            /// <item><description>SET_SUCCESS: Set to success.</description></item>
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
