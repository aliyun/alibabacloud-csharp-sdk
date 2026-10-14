// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyAICInstanceTypeRequest : TeaModel {
        /// <summary>
        /// <para>One or more environment variables to set during instance initialization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[object Object]</para>
        /// </summary>
        [NameInMap("EnvironmentVar")]
        [Validation(Required=false)]
        public string EnvironmentVar { get; set; }

        /// <summary>
        /// <para>The refresh rate. Unit: Hz. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>30</description></item>
        /// <item><description>60</description></item>
        /// <item><description>120</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public long? Frequency { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourImage ID</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The ID of the instance whose specifications you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aic-xxxx-0</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The target AIC container instance specifications.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aic.cf52r.c1.np</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The resolution. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1920*1080</description></item>
        /// <item><description>1080*1920</description></item>
        /// <item><description>1280*720</description></item>
        /// <item><description>720*1280</description></item>
        /// <item><description>2400*1080</description></item>
        /// <item><description>1080*2400</description></item>
        /// <item><description>1920*864</description></item>
        /// <item><description>864*1920</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>720*1280</para>
        /// </summary>
        [NameInMap("Resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

    }

}
