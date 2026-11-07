// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListTaskStepResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of records returned in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of step definitions for the specified task type.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListTaskStepResponseBodyData> Data { get; set; }
        public class ListTaskStepResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The interaction method of the step. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>prompt</b>: Displays step prompts.</description></item>
            /// <item><description><b>connection</b>: Provides connection operations to enter the builder or validation environment.</description></item>
            /// <item><description><b>prompt_connection</b>: Provides both prompts and connection operations.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>connection</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The Chinese name of the phase to which the step belongs, such as builder environment preparation or test validation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>制作环境准备</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The English name of the phase to which the step belongs. This field is returned for image creation steps, but may not be returned for application adaptation steps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Builder Environment Preparation</para>
            /// </summary>
            [NameInMap("CategoryEn")]
            [Validation(Required=false)]
            public string CategoryEn { get; set; }

            /// <summary>
            /// <para>The numeric index of the step definition, which is used to identify the step and its sequence. Do not use this value as the completion percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            /// <summary>
            /// <para>The name identifier of the step, which is used to match the step records returned by GetTask.</para>
            /// <para>Steps when Type is set to IMAGE:</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: Initialize the task.</description></item>
            /// <item><description><b>CREATE_BUILDER_ENV</b>: Create the builder environment.</description></item>
            /// <item><description><b>DEPLOY_BUILDER_ENV</b>: Deploy the builder environment.</description></item>
            /// <item><description><b>INIT_BUILDER</b>: Initialize the builder tool.</description></item>
            /// <item><description><b>DOWNLOAD_APP</b>: Download application resources.</description></item>
            /// <item><description><b>START_BUILD</b>: Start image creation.</description></item>
            /// <item><description><b>COMPLETE_INSTALL</b>: Complete application installation and configuration.</description></item>
            /// <item><description><b>CREATE_VALIDATE_ENV</b>: Create the validation environment.</description></item>
            /// <item><description><b>DEPLOY_VALIDATE_ENV</b>: Deploy the validation environment.</description></item>
            /// <item><description><b>COMPLETE_VALIDATE</b>: Complete image validation.</description></item>
            /// <item><description><b>ARCHIVE_DATA</b>: Archive image data.</description></item>
            /// <item><description><b>CREATE_IMAGE</b>: Generate the image.</description></item>
            /// <item><description><b>FINISH_ADAPT</b>: End the creation process.</description></item>
            /// </list>
            /// <para>Steps when Type is set to ADAPTOR:</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: Initialize the task.</description></item>
            /// <item><description><b>CREATE_BUILDER_ENV</b>: Create the builder environment.</description></item>
            /// <item><description><b>DEPLOY_BUILDER_ENV</b>: Deploy the builder environment.</description></item>
            /// <item><description><b>INIT_BUILDER</b>: Initialize the builder tool.</description></item>
            /// <item><description><b>DOWNLOAD_APP</b>: Download application resources.</description></item>
            /// <item><description><b>START_VHD</b>: Start application recording.</description></item>
            /// <item><description><b>BUILD_VHD</b>: Generate the application VHD.</description></item>
            /// <item><description><b>UPLOAD_VHD</b>: Upload the application VHD.</description></item>
            /// <item><description><b>COMPLETE_BUILDER</b>: Complete application creation.</description></item>
            /// <item><description><b>CREATE_VALIDATE_ENV</b>: Create the validation environment.</description></item>
            /// <item><description><b>DEPLOY_VALIDATE_ENV</b>: Deploy the validation environment.</description></item>
            /// <item><description><b>COMPLETE_VALIDATE</b>: Complete application validation.</description></item>
            /// <item><description><b>CREATE_IMAGE</b>: Generate the application image.</description></item>
            /// <item><description><b>FINISH_ADAPT</b>: End the application adaptation process.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE_BUILDER_ENV</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request. You can provide this value for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A1A962-5503-107B-AC8F-EBA85DF905AC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
